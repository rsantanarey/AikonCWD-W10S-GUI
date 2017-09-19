using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AikonCWD_W10S_GUI.Forms
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        #region Buttons

        #region 1

        private void btn_1_si_Click(object sender, EventArgs e)
        {
            /// oWSH.RegWrite "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\LaunchTo", 1, "REG_DWORD"
            //Logic.Registry.ChangeRegistry(1, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\LaunchTo",)
        }

        #endregion

        private void btn_2_si_Click(object sender, EventArgs e)
        {

        }

        private void btn_2_no_Click(object sender, EventArgs e)
        {

        }

        #region 2

        #endregion

        #region 3

        private void btn_3_si_Click(object sender, EventArgs e)
        {
            //"HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize\AppsUseLightTheme", 0, "REG_DWORD"
            Logic.Registry.ChangeRegistry(2, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize\", "AppsUseLightTheme", "0");
            Logic.Registry.ChangeRegistry(1, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize\", "AppsUseLightTheme", "0");
        }

        private void btn_3_no_Click(object sender, EventArgs e)
        {
            Logic.Registry.ChangeRegistry(2, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize\", "AppsUseLightTheme", "1");
            Logic.Registry.ChangeRegistry(1, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize\", "AppsUseLightTheme", "1");

        }

        #endregion

        #region 4

        private void btn_4_si_Click(object sender, EventArgs e)
        {
            /// oWSH.RegWrite "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel\{20D04FE0-3AEA-1069-A2D8-08002B30309D}", 0, "REG_DWORD"
            Logic.Registry.ChangeRegistry(1, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel\", "{20D04FE0-3AEA-1069-A2D8-08002B30309D}", "0");
        }

        private void btn_4_no_Click(object sender, EventArgs e)
        {
            Logic.Registry.ChangeRegistry(1, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel\", "{20D04FE0-3AEA-1069-A2D8-08002B30309D}", "1");
        }


        #endregion

        #region 5

        private void btn_5_si_Click(object sender, EventArgs e)
        {
            Logic.Registry.ChangeRegistry(1, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "HideFileExt", "0");

        }

        private void btn_5_no_Click(object sender, EventArgs e)
        {
            Logic.Registry.ChangeRegistry(1, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "HideFileExt", "1");
        }


        #endregion

        #region 6

        private void btn_6_si_Click(object sender, EventArgs e)
        {
            ///"HKLM\SOFTWARE\Policies\Microsoft\Windows\Personalization\NoLockScreen", 1, "REG_DWORD"
            Logic.Registry.ChangeRegistry(2, @"SOFTWARE\Policies\Microsoft\Windows\Personalization\", "NoLockScreen", "1");
            Logic.Registry.ChangeRegistry(2, @"Software\Policies\Microsoft\Windows\System\", "DisableLogonBackgroundImage", "1");
        }

        private void btn_6_no_Click(object sender, EventArgs e)
        {
            Logic.Registry.ChangeRegistry(2, @"SOFTWARE\Policies\Microsoft\Windows\Personalization\", "NoLockScreen", "0");
            Logic.Registry.ChangeRegistry(2, @"Software\Policies\Microsoft\Windows\System\", "DisableLogonBackgroundImage", "0");
        }


        #endregion

        #region 7

        private void btn_7_si_Click(object sender, EventArgs e)
        {
            Logic.Registry.ChangeRegistry(1, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\", "ForceClassicControlPanel", "1");

        }

        private void btn_7_no_Click(object sender, EventArgs e)
        {
            Logic.Registry.ChangeRegistry(1, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\", "ForceClassicControlPanel", "0");

        }


        #endregion

        #region 8

        private void btn_8_si_Click(object sender, EventArgs e)
        {

        }

        private void btn_8_no_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #region 9

        private void btn_9_si_Click(object sender, EventArgs e)
        {

        }

        private void btn_9_no_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #region 10



        #endregion

        #region 11

        private void btn_11_si_Click(object sender, EventArgs e)
        {

        }

        private void btn_11_no_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 12

        private void btn_10_si_Click(object sender, EventArgs e)
        {

        }

        private void btn_10_no_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 13

        private void btn_13_si_Click(object sender, EventArgs e)
        {

        }

        private void btn_13_no_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 14

        private void btn_14_si_Click(object sender, EventArgs e)
        {

        }

        private void btn_14_no_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion
    }
}
