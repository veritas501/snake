using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
	public partial class settingForm : Form
	{
		FormMain frm = null;
		public settingForm(FormMain Infrm)
		{
			frm = Infrm;
			InitializeComponent();
		}

		private void settingForm_Load(object sender, EventArgs e)
		{
			//初始化ComboBox的选项
			comboBoxMapSize.DataSource = System.Enum.GetNames(typeof(GameConfig._mapsize));
			comboBoxDifficulty.DataSource = System.Enum.GetNames(typeof(GameConfig._difficulty));

			//根据当前配置项，设置ComboBox当前选中的Index
			switch (GameConfig.MapSize)
			{
				case GameConfig._mapsize.Small:
					{
						comboBoxMapSize.SelectedIndex = 0;
						break;
					}
				case GameConfig._mapsize.Medium:
					{
						comboBoxMapSize.SelectedIndex = 1;
						break;
					}
				case GameConfig._mapsize.Big:
					{
						comboBoxMapSize.SelectedIndex = 2;
						break;
					}
			}

			comboBoxDifficulty.SelectedIndex = (int)GameConfig.Difficulty;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			//取出选定的配置,写到配置
			switch(comboBoxMapSize.SelectedIndex){
				case 0:
					{
						GameConfig.MapSize = GameConfig._mapsize.Small;
						break;
					}
				case 1:
					{
						GameConfig.MapSize = GameConfig._mapsize.Medium;
						break;
					}
				case 2:
					{
						GameConfig.MapSize = GameConfig._mapsize.Big;
						break;
					}
			}

			switch (comboBoxDifficulty.SelectedIndex)
			{
				case 0:
					{
						GameConfig.Difficulty = GameConfig._difficulty.Easy;
						break;
					}
				case 1:
					{
						GameConfig.Difficulty = GameConfig._difficulty.Normal;
						break;
					}
				case 2:
					{
						GameConfig.Difficulty = GameConfig._difficulty.Hard;
						break;
					}
			}
			if (frm!=null)
			{
				frm.FormMainResizeWindow();
			}
			Close();
		}
	}
}
