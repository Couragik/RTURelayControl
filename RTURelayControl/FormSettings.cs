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

        public FormSettings(SettingsSectionEnum initialSection)
        {
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

        public void InitializeTags()
        {
            settingsTreeView.Nodes[0].Tag = SettingsSectionEnum.Program;
            settingsTreeView.Nodes[1].Tag = SettingsSectionEnum.Interface;
            settingsTreeView.Nodes[2].Tag = SettingsSectionEnum.Timer;
            settingsTreeView.Nodes[3].Tag = SettingsSectionEnum.Automat;
        }

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

    }
}
