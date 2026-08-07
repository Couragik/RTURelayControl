using RTURelayControl.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTURelayControl
{
    public partial class FormSettings : Form
    {
        private readonly SettingsSectionEnum _initialSection;
        private readonly AppRuntimeState _appRuntimeState;      

        private SettingsData _settingsDraft;

        private bool _formChanged = false;
        public FormSettings(SettingsSectionEnum initialSection, AppRuntimeState appRuntimeState)
        {
            _settingsDraft = AppSettings.Current.Clone();
            _appRuntimeState = appRuntimeState;
            _initialSection = initialSection;

            InitializeComponent();

            InitializeTags();

            InitializeFormElements();
            
            //Загрузка текущих настроек в поля формы
            LoadControlsData(tabControlSettings, _settingsDraft);

            //Включить отслеживаниие изменения формы
            _formChanged = true;
        }

        /// <summary>
        /// Инициализируем элементы формы и меняем их вид
        /// </summary>
        private void InitializeFormElements()
        {
            //Изменяем вид tabControlSettings убрав заголовки
            tabControlSettings.Appearance = TabAppearance.FlatButtons;
            tabControlSettings.ItemSize = new Size(0, 1);
            tabControlSettings.SizeMode = TabSizeMode.Fixed;
            tabControlSettings.Alignment = TabAlignment.Top;

            //Развернуть все пункты настроек в 
            settingsTreeView.ExpandAll();
            
            //Выбираем начальный пункт меню
            SelectSection(_initialSection);

            //Включаем доступ к настройке автозапуска
            checkBoxAutoStart.Enabled = _appRuntimeState.IsRunAsAdmin;
        }

        /// <summary>
        /// Добавляет Enum теги к элементам навигации
        /// </summary>
        public void InitializeTags()
        {
            //Задаем теги для TreeView
            settingsTreeView.Nodes["NodeApp"].Tag = SettingsSectionEnum.Program;
            settingsTreeView.Nodes["NodeInterface"].Tag = SettingsSectionEnum.Interface;
            settingsTreeView.Nodes["NodeTimer"].Tag = SettingsSectionEnum.Timer;
            settingsTreeView.Nodes["NodeAuto"].Tag = SettingsSectionEnum.Automat;

            //Задаем теги для TabControl
            tabProgram.Tag = SettingsSectionEnum.Program;
            tabInterface.Tag = SettingsSectionEnum.Interface;
            tabTimer.Tag = SettingsSectionEnum.Timer;
            tabAutomat.Tag = SettingsSectionEnum.Automat;
        }

        /// <summary>
        /// Проверка TreeView для выбора нужного пункта меню и вкладки TabControl
        /// </summary>
        private void SelectSection(SettingsSectionEnum section)
        {
            foreach (TreeNode node in settingsTreeView.Nodes)
            {
                if((SettingsSectionEnum)node.Tag == section)
                {
                    settingsTreeView.SelectedNode = node;
                    node.EnsureVisible();
                    break;
                }
            }
        }

        /// <summary>
        /// Переключаем нужную вкладку в зависи от выбранного Enum тега
        /// </summary>
        private void SelectSettingsTab(SettingsSectionEnum section)
        { 
            foreach (TabPage tab in tabControlSettings.TabPages)
            {
                if ((SettingsSectionEnum)tab.Tag == section)
                {
                    tabControlSettings.SelectedTab = tab;
                    break;
                }
            }
        }

        /// <summary>
        /// Рекурсивная загрузка текущих настроек в форму для отображения пользователю
        /// </summary>
        /// <param name="parent">
        /// Родительский элемент формы для поиска
        /// </param>
        /// <param name="settings">
        /// Источник данных
        /// </param>
        private void LoadControlsData(Control parent, SettingsData settings)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.Tag is string propertyName)
                {
                    //Описание типа свойства
                    var property = typeof(SettingsData).GetProperty(propertyName);

                    if (property != null)
                    {
                        object value = property.GetValue(settings);

                        //Проверки типов элементов с приведением типа и присвоение данных
                        if (control is CheckBox checkBox)
                            checkBox.Checked = (bool)value;

                        else if (control is TextBox textBox)
                            textBox.Text = value?.ToString() ?? "";

                        else if (control is NumericUpDown numericUpDown)
                            numericUpDown.Value = Convert.ToDecimal(value);
                    }
                }

                LoadControlsData(control, settings);
            }
        }

        /// <summary>
        /// Рекурсивное сохранение данных с формы в источник данных
        /// </summary>
        /// <param name="parent">
        /// Родительский элемент формы для поиска
        /// </param>
        /// <param name="settings">
        /// Источник данных
        /// </param>
        private void SaveControlsData(Control parent, SettingsData settings)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.Tag is string propertyName)
                {
                    //Описание типа свойства
                    var property = typeof(SettingsData).GetProperty(propertyName);

                    if (property != null)
                    {
                        //Проверки типов элементов с приведением типа и присвоение данных
                        if (control is CheckBox checkBox)
                            property.SetValue(settings, checkBox.Checked);

                        else if (control is TextBox textBox)
                            property.SetValue(settings, textBox.Text);

                        else if (control is NumericUpDown numericUpDown)
                            property.SetValue(
                                settings,
                                Convert.ToInt32(numericUpDown.Value));
                    }
                }

                SaveControlsData(control, settings);
            }
        }

        private void settingsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectSettingsTab((SettingsSectionEnum)e.Node.Tag);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Переносим параметры с формы в переменную
            SaveControlsData(tabControlSettings, _settingsDraft);

            List<string> errors;

            //Проверка введенных значений
            if(!_settingsDraft.IsValid(out errors))
            {
                MessageBox.Show(
                    string.Join(
                        Environment.NewLine, 
                        errors.Select(error => "• " + error)),
                    Resources.UiText.SettingsFormErrMessage,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            //Сохранение настроек
            AppSettings.SaveAndApply(_settingsDraft);

            this.Close();
        }

        private void formElements_ValChanged(object sender, EventArgs e)
        {
            buttonSave.Enabled = _formChanged;
        }
    }
}
