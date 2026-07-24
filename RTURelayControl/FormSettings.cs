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

        private SettingsData _settingsDraft;

        public FormSettings(SettingsSectionEnum initialSection)
        {
            _settingsDraft = AppSettings.Current.Clone();

            InitializeComponent();
            InitializeTags();

            //Изменяем вид tabControlSettings убрав заголовки
            tabControlSettings.Appearance = TabAppearance.FlatButtons;
            tabControlSettings.ItemSize = new Size(0, 1);
            tabControlSettings.SizeMode = TabSizeMode.Fixed;
            tabControlSettings.Alignment = TabAlignment.Top;

            //Развернуть все пункты настроек в 
            settingsTreeView.ExpandAll();
            
            //Выбираем начальный пункт меню
            _initialSection = initialSection;
            SelectSection(_initialSection);
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
            _settingsDraft.PollInterval = 100;
            AppSettings.SaveAndApply(_settingsDraft);
        }
    }
}
