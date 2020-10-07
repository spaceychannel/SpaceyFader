using Sanford.Multimedia.Midi;
using Sanford.Multimedia.Midi.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceyFader
{
    public partial class SpaceyFader : Form
    {
        private OutputDevice outDevice;
        private int outDeviceID = -1;
        private OutputDeviceDialog outDialog;

        private InputDevice inDevice;
        private int inDeviceID = -1;
        private InputDeviceDialog inDialog;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SpaceyFader()
        {
            InitializeComponent();
            
        }
        #region デバイス設定
        /// <summary>
        /// 出力デバイス設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOutDevice_Click(object sender, EventArgs e)
        {
            outDialog = new OutputDeviceDialog();
            if( outDialog.ShowDialog() == DialogResult.OK)
            {
                outDeviceID = outDialog.OutputDeviceID;
                lbOutDevice.Text = outDialog.DeviceName;

                outDevice = new OutputDevice(outDeviceID);

                // 初期値の送信
                this.btnReset2_Click(sender, e);

                this.trackbarLev1.Value = 0;
                this.trackbarLev2.Value = 0;
            }
        }

        /// <summary>
        /// 入力デバイス設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInDevice_Click(object sender, EventArgs e)
        {
            inDialog = new InputDeviceDialog();
            if (inDialog.ShowDialog() == DialogResult.OK)
            {
                inDeviceID = inDialog.InputDeviceID;
                lbInDevice.Text = inDialog.DeviceName;

                inDevice = new InputDevice(inDeviceID);
                inDevice.ChannelMessageReceived += InDevice_ChannelMessageReceived;

                inDevice.StartRecording();
            }
        }

        /// <summary>
        /// メッセージ受信
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InDevice_ChannelMessageReceived(object sender, ChannelMessageEventArgs e)
        {
            lock (this)
            {
                if (e.Message.Command == ChannelCommand.Controller)
                {
                    // deck1
                    if (e.Message.MidiChannel == 0)
                    {
                        switch (e.Message.Data1)
                        {
                            case 3:
                                // Queue
                                this.cboxQue1.CheckedChanged -= cboxQue1_CheckedChanged;
                                bool bCheck = e.Message.Data2 == 127;
                                this.cboxQue1.Checked = bCheck;
                                this.cboxQue1.CheckedChanged += cboxQue1_CheckedChanged;
                                break;

                            case 4:
                                // Level
                                this.trackbarLev1.ValueChanged -= trackbarLev1_ValueChanged;
                                this.trackbarLev1.Value = e.Message.Data2;
                                this.lbLev1.Text = this.trackbarLev1.Value.ToString();
                                this.trackbarLev1.ValueChanged += trackbarLev1_ValueChanged;
                                break;

                            case 5:
                                // Low
                                this.trackbarLow1.ValueChanged -= trackbarLow1_ValueChanged;
                                this.trackbarLow1.Value = e.Message.Data2;
                                this.lbLow1.Text = this.trackbarLow1.Value.ToString();
                                this.trackbarLow1.ValueChanged += trackbarLow1_ValueChanged;
                                break;

                            case 6:
                                // Mid
                                this.trackbarMid1.ValueChanged -= trackbarMid1_ValueChanged;
                                this.trackbarMid1.Value = e.Message.Data2;
                                this.lbMid1.Text = this.trackbarMid1.Value.ToString();
                                this.trackbarMid1.ValueChanged += trackbarMid1_ValueChanged;
                                break;

                            case 7:
                                // High
                                this.trackbarHigh1.ValueChanged -= trackbarHigh1_ValueChanged;
                                this.trackbarHigh1.Value = e.Message.Data2;
                                this.lbHigh1.Text = this.trackbarHigh1.Value.ToString();
                                this.trackbarHigh1.ValueChanged += trackbarHigh1_ValueChanged;
                                break;

                            default:
                                break;
                        }
                    }

                    // deck2
                    if (e.Message.MidiChannel == 1)
                    {
                        switch (e.Message.Data1)
                        {
                            case 3:
                                // Queue
                                this.cboxQue2.CheckedChanged -= cboxQue2_CheckedChanged;
                                bool bCheck = e.Message.Data2 == 127;
                                this.cboxQue2.Checked = bCheck;
                                this.cboxQue2.CheckedChanged += cboxQue2_CheckedChanged;
                                break;

                            case 4:
                                // Level
                                this.trackbarLev2.ValueChanged -= trackbarLev2_ValueChanged;
                                this.trackbarLev2.Value = e.Message.Data2;
                                this.lbLev2.Text = this.trackbarLev2.Value.ToString();
                                this.trackbarLev2.ValueChanged += trackbarLev2_ValueChanged;
                                break;

                            case 5:
                                // Low
                                this.trackbarLow2.ValueChanged -= trackbarLow2_ValueChanged;
                                this.trackbarLow2.Value = e.Message.Data2;
                                this.lbLow2.Text = this.trackbarLow2.Value.ToString();
                                this.trackbarLow2.ValueChanged += trackbarLow2_ValueChanged;
                                break;

                            case 6:
                                // Mid
                                this.trackbarMid2.ValueChanged -= trackbarMid2_ValueChanged;
                                this.trackbarMid2.Value = e.Message.Data2;
                                this.lbMid2.Text = this.trackbarMid2.Value.ToString();
                                this.trackbarMid2.ValueChanged += trackbarMid2_ValueChanged;
                                break;
                                
                            case 7:
                                // High
                                this.trackbarHigh2.ValueChanged -= trackbarHigh2_ValueChanged;
                                this.trackbarHigh2.Value = e.Message.Data2;
                                this.lbHigh2.Text = this.trackbarHigh2.Value.ToString();
                                this.trackbarHigh2.ValueChanged += trackbarHigh2_ValueChanged;
                                break;

                            default:
                                break;
                        }
                    }
                }
            }
        }
        #endregion

        #region deck1
        /// <summary>
        /// deck1 High 設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackbarHigh1_ValueChanged(object sender, EventArgs e)
        {
            lock(this)
            {
                this.lbHigh1.Text = this.trackbarHigh1.Value.ToString();
                if (outDevice != null)
                {
                    outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 7, this.trackbarHigh1.Value));
                }
            }
        }

        /// <summary>
        /// deck1 Mid 設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackbarMid1_ValueChanged(object sender, EventArgs e)
        {
            lock (this)
            {
                this.lbMid1.Text = this.trackbarMid1.Value.ToString();
                if (outDevice != null)
                {
                    outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, this.trackbarMid1.Value));
                }
            }
        }

        /// <summary>
        /// deck1 Low 設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackbarLow1_ValueChanged(object sender, EventArgs e)
        {
            lock (this)
            {
                this.lbLow1.Text = this.trackbarLow1.Value.ToString();
                if (outDevice != null)
                {
                    outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 5, this.trackbarLow1.Value));
                }
            }
        }

        /// <summary>
        /// deck1 Level 設定 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackbarLev1_ValueChanged(object sender, EventArgs e)
        {
            lock (this)
            {
                this.lbLev1.Text = this.trackbarLev1.Value.ToString();
                if (outDevice != null)
                {
                    outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 4, this.trackbarLev1.Value));
                }
            }
        }

        /// <summary>
        /// deck1 キュー 設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxQue1_CheckedChanged(object sender, EventArgs e)
        {
            lock (this)
            {
                int value = cboxQue1.Checked ? 127 : 0;
                if (outDevice != null)
                {
                    outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 3, value));
                }
            }
        }
        #endregion

        #region deck2
        /// <summary>
        /// deck2 High 設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackbarHigh2_ValueChanged(object sender, EventArgs e)
        {
            lock (this)
            {
                this.lbHigh2.Text = this.trackbarHigh2.Value.ToString();
                if (outDevice != null)
                {
                    outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 1, 7, this.trackbarHigh2.Value));
                }
            }
        }

        /// <summary>
        /// deck2 Mid 設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackbarMid2_ValueChanged(object sender, EventArgs e)
        {
            lock (this)
            {
                this.lbMid2.Text = this.trackbarMid2.Value.ToString();
                if (outDevice != null)
                {
                    outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 1, 6, this.trackbarMid2.Value));
                }
            }
        }

        /// <summary>
        /// deck2 Low 設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackbarLow2_ValueChanged(object sender, EventArgs e)
        {
            lock (this)
            {
                this.lbLow2.Text = this.trackbarLow2.Value.ToString();
                if (outDevice != null)
                {
                    outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 1, 5, this.trackbarLow2.Value));
                }
            }
        }

        /// <summary>
        /// deck2 Level 設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackbarLev2_ValueChanged(object sender, EventArgs e)
        {
            lock (this)
            {
                this.lbLev2.Text = this.trackbarLev2.Value.ToString();
                if (outDevice != null)
                {
                    outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 1, 4, this.trackbarLev2.Value));
                }
            }
        }

        /// <summary>
        /// deck2 キュー 設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxQue2_CheckedChanged(object sender, EventArgs e)
        {
            lock (this)
            {
                int value = cboxQue2.Checked ? 127 : 0;
                if (outDevice != null)
                {
                    outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 1, 3, value));
                }
            }
        }
        #endregion


        private void btnReset1_Click(object sender, EventArgs e)
        {
            this.trackbarHigh1.Value = 63;
            this.trackbarMid1.Value = 63;
            this.trackbarLow1.Value = 63;
            this.trackbarLev1.Value = 0;
        }


        /// <summary>
        /// リセットボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset2_Click(object sender, EventArgs e)
        {
            this.trackbarHigh2.Value = 63;
            this.trackbarMid2.Value = 63;
            this.trackbarLow2.Value = 63;
            this.trackbarLev2.Value = 0;
        }

        private void btnCutin1_Click(object sender, EventArgs e)
        {
            this.trackbarLev1.Value = 127;
            this.trackbarLev2.Value = 0;
        }

        private void btnCutIn2_Click(object sender, EventArgs e)
        {
            this.trackbarLev1.Value = 0;
            this.trackbarLev2.Value = 127;
        }

        #region shortcuts

        /// <summary>
        /// キーボードショートカット
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpaceyFader_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            string value = e.KeyData.ToString();

            switch (value)
            {
                // High------------------------------
                case "D1":
                    this.trackbarHigh1.Value = NewValue(this.trackbarHigh1.Value, false);
                    break;

                case "D2":
                    this.trackbarHigh1.Value = NewValue(this.trackbarHigh1.Value, true);
                    break;

                case "D3":
                    this.trackbarHigh2.Value = NewValue(this.trackbarHigh2.Value, false);
                    break;

                case "D4":
                    this.trackbarHigh2.Value = NewValue(this.trackbarHigh2.Value, true);
                    break;

                // Mid----------------------------------
                case "Q":
                    this.trackbarMid1.Value = NewValue(this.trackbarMid1.Value, false);
                    break;

                case "W":
                    this.trackbarMid1.Value = NewValue(this.trackbarMid1.Value, true);
                    break;

                case "E":
                    this.trackbarMid2.Value = NewValue(this.trackbarMid2.Value, false);
                    break;

                case "R":
                    this.trackbarMid2.Value = NewValue(this.trackbarMid2.Value, true);
                    break;

                // Low----------------------------------
                case "A":
                    this.trackbarLow1.Value = NewValue(this.trackbarLow1.Value, false);
                    break;

                case "S":
                    this.trackbarLow1.Value = NewValue(this.trackbarLow1.Value, true);
                    break;

                case "D":
                    this.trackbarLow2.Value = NewValue(this.trackbarLow2.Value, false);
                    break;

                case "F":
                    this.trackbarLow2.Value = NewValue(this.trackbarLow2.Value, true);
                    break;

                // Level----------------------------------
                case "Z":
                    this.trackbarLev1.Value = NewValue(this.trackbarLev1.Value, false);
                    break;

                case "X":
                    this.trackbarLev1.Value = NewValue(this.trackbarLev1.Value, true);
                    break;

                case "C":
                    this.trackbarLev2.Value = NewValue(this.trackbarLev2.Value, false);
                    break;

                case "V":
                    this.trackbarLev2.Value = NewValue(this.trackbarLev2.Value, true);
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// 次の値をセットする。
        /// </summary>
        /// <param name="input"></param>
        /// <param name="isPositive"></param>
        /// <returns></returns>
        private int NewValue(int input, bool isPositive)
        {
            int nRet = 0;

            if(isPositive)
            {
                nRet = input + 5;
                if (nRet > 127)
                    nRet = 127;
            }
            else
            {
                nRet = input- 5;
                if (nRet < 0)
                    nRet = 0;
            }

            return nRet;
        }

        #endregion
    }
}
