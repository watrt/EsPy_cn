//using EsPy.Python;
//using EsPy.Python.Jedi;
using EsPy.Utility;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using static EsPy.Utility.TextHelper;

namespace EsPy.Components
{
    public class ExScintilla : Scintilla
    {

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        private const int NUMBER_MARGIN = 1;
        private const int BOOKMARK_MARGIN = 2;
        private const int BOOKMARK_MARKER = 2;

        const int WM_KEYDOWN = 0x100;
        const int WM_SYSKEYDOWN = 0x104;
        const int WM_LBUTTONDOWN = 0x0201;
        public string Lang = "";
        public string CommentLine = "";
        public string CommentStart = "";
        public string CommentEnd = "";

        public ExScintilla() : base()
        {
            this.InitializeComponent();
            //this.CompletionEnabled = false;
            //this.Completions = new List<Completion>(500);
            //this.MouseDwellTime = 500;
        }

        //public bool CompletionEnabled
        //{ get; set; }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ExScintilla
            // 
            this.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.ExScintilla_CharAdded);
            this.Delete += new System.EventHandler<ScintillaNET.ModificationEventArgs>(this.ExScintilla_Delete);
            this.DwellEnd += new System.EventHandler<ScintillaNET.DwellEventArgs>(this.ExScintilla_DwellEnd);
            this.TextChanged += new System.EventHandler(this.ExScintilla_TextChanged);
            this.Leave += new System.EventHandler(this.ExScintilla_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExScintilla_MouseDown);
            this.MouseHover += new System.EventHandler(this.ExScintilla_MouseHover);
            this.Resize += new System.EventHandler(this.ExScintilla_Resize);
            this.ResumeLayout(false);

        }

        //private CompletionForm FCompletionForm = null;
        //public void HideCompletions()
        //{
        //    if (this.FCompletionForm != null)
        //    {
        //        this.FCompletionForm.Dispose();
        //        this.FCompletionForm = null;
        //    }
        //}

        //public void CompletionFormDisposing(object sender, EventArgs e)
        //{
        //    this.FCompletionForm.FormDisposing -= CompletionFormDisposing;
        //    this.FCompletionForm = null;
        //}

        //public void ShowCompletion()
        //{
        //    //this.Capture = true;
        //    this.HideCompletions();
        //    this.FCompletionForm = new CompletionForm();
        //    this.FCompletionForm.FormDisposing += CompletionFormDisposing;
        //    this.FCompletionForm.Scintilla = this;

        //    int word_start_pos = Utility.TextHelper.KeywordStartPosition(this.Text, this.CurrentPosition - 1) + 1;
        //    int x = this.PointXFromPosition(word_start_pos);
        //    int y = this.PointYFromPosition(word_start_pos);

        //    this.FCompletionForm.Show();

        //    Point p = this.PointToScreen(new Point(x, y));

        //    this.FCompletionForm.TopLevel = true;
        //    this.FCompletionForm.TopMost = true;
        //    this.FCompletionForm.Top = p.Y + (int)(this.Font.Height * 1.2);
        //    this.FCompletionForm.Left = p.X;
        //    this.Focus();
        //    this.SetFilter(0);
        //}

        //private List<Completion> Completions
        //{get; set; }

        //private void SetFilter(int dx)
        //{
        //    this.FCompletionForm.Clear();
        //    Line line = this.Lines[this.CurrentLine];
        //    int l = this.CurrentLine + dx;
        //    int c = this.CurrentPosition - line.Position;

        //    Words words = TextHelper.FindWords(line.Text, c + dx);
            
        //    List<Completion> list = this.Completions.Where(k => k.name.ToLower().StartsWith(words.Filter.ToLower())).ToList();

        //    // Todo: Add/Remove items
        //    this.FCompletionForm.AddRange(list);

        //    if (words.Filter != "" && this.FCompletionForm.Count > 0)
        //    {
        //        this.FCompletionForm.SelectedIndex = 0;
        //    }
        //    else
        //    {
                
        //    }
        //}

        //private void Complete()
        //{
            
        //    if (this.FCompletionForm.SelectedItem != null)
        //    {
        //        string name = this.FCompletionForm.SelectedItem.name;
        //        // prevent Delete & Insert events!!)
        //        this.HideCompletions();

        //        if (name != null)
        //        {
        //            Line line = this.Lines[this.CurrentLine];
        //            int l = this.CurrentLine + 1;
        //            int c = this.CurrentPosition - line.Position;

        //            Words words = TextHelper.FindWords(line.Text, c);

        //            this.DeleteRange(line.Position + words.Pos, words.Filter.Length);
        //            this.InsertText(line.Position + words.Pos, name);
        //            this.GotoPosition(line.Position + words.Pos + name.Length);                    
        //        }
        //    }
        //    else this.HideCompletions();
        //}
         
        //protected override void WndProc(ref Message m)
        //{
        //    if (this.FCompletionForm != null)
        //    {
        //        if (m.Msg == WM_LBUTTONDOWN)
        //        {
        //            PostMessage(this.FCompletionForm.Handle, (uint) m.Msg,(int) m.WParam,(int)m.LParam);
        //            return;
        //        }
        //    }
        //    base.WndProc(ref m);
        //}

        //protected override bool ProcessCmdKey(ref Message msg, Keys key)
        //{
        //    if (msg.Msg == WM_KEYDOWN || msg.Msg == WM_SYSKEYDOWN)
        //    {
        //        switch (key)
        //        {
        //            case Keys.Control | Keys.Space:                      
        //                //this.FindCompletions();
        //                return true;

        //            case Keys.Escape:
        //                //this.HideCompletions();
        //                return true;

        //            case Keys.Enter:
        //            case Keys.Tab:
        //                //if (this.FCompletionForm != null)
        //                //{
        //                //    this.Complete();
        //                //    return true;
        //                //}
        //                break;

        //            case Keys.Left:

        //                //if (this.FCompletionForm != null)
        //                //{
        //                //    int p = this.CurrentPosition - 1;
        //                //    char c = this.Text[p];
        //                //    if (c == '.' || char.IsWhiteSpace(c))
        //                //    {
        //                //        this.HideCompletions();
                                
        //                //    }
        //                //    else
        //                //    {
        //                //        this.SetFilter(-1);
        //                //    }
        //                //}
        //                break;

        //            case Keys.Right:
        //                //if (this.FCompletionForm != null)
        //                //{
        //                //    int p = this.CurrentPosition ;
        //                //    char c = this.Text[p];
        //                //    if (c == '.' || char.IsWhiteSpace(c))
        //                //    {
        //                //        this.HideCompletions();
        //                //    }
        //                //    else
        //                //    {
        //                //        this.SetFilter(1);
        //                //    }
        //                //}
        //                break;

        //            case Keys.Up:
        //                //if (this.FCompletionForm != null)
        //                //{
        //                //    this.FCompletionForm.SelectPrevious();
        //                //    return true;
        //                //}
        //                break;

        //            case Keys.Down:
        //                //if (this.FCompletionForm != null)
        //                //{
        //                //    this.FCompletionForm.SelectNext();
        //                //    return true;
        //                //}
        //                break;

        //            case Keys.Home:
        //                //if (this.FCompletionForm != null)
        //                //{
        //                //    this.HideCompletions();
        //                //}
        //                break;

        //            case Keys.End:
        //                //if (this.FCompletionForm != null)
        //                //{
        //                //    this.HideCompletions();
        //                //}
        //                break;
        //        }
        //    }
        //    return base.ProcessCmdKey(ref msg, key);
        //}

        //private int CompletionPosition = 0;

        //private void FindCompletions()
        //{
        //    Line line = this.Lines[this.CurrentLine];
        //    int l = this.CurrentLine + 1;
        //    int c = this.CurrentPosition - line.Position;
        //    Words words = TextHelper.FindWords(line.Text, c);
        //    this.CompletionPosition = line.Position + words.Pos;
        //    this.FindCompletions(l, c);
        //}

        //private void FindCompletions(int line, int column)
        //{
        //    if (Globals.PyClient != null && this.Lexer == Lexer.Python && this.CompletionEnabled)
        //    {
        //        this.HideCompletions();
        //        this.Completions.Clear();

        //        Script script = new Script(this.Text, line, column);

        //        PyRequest req = new CompletionRequest(script);
        //        string json = JsonConvert.SerializeObject(req);
        //        try
        //        {
        //            JToken token = Globals.PyClient.DoRequest<JToken>(req);
        //            if (token != null && token["completions"] is JArray)
        //            {
        //                JArray items = token["completions"] as JArray;
        //                foreach (JToken t in items)
        //                {
        //                    Completion comp = JsonConvert.DeserializeObject<Completion>(t.ToString());
        //                    if (comp != null)
        //                        this.Completions.Add(comp);
        //                }

        //                //Todo: move to Show
        //                if (this.Completions.Count > 0)
        //                {
        //                    this.ShowCompletion();
        //                }
        //                else
        //                {
        //                    this.CallTipShow(this.CurrentPosition, "No suggestions");
        //                }
        //            }
        //        }
        //        catch
        //        { 
        //            this.CallTipShow(this.CurrentPosition, "Try again**");
        //        }
        //    }
        //}

        private string GetAttr(XmlNode xnode, string attr)
        {
            if (xnode != null && xnode.Attributes[attr] != null && xnode.Attributes[attr].Value != null)
            {
                return xnode.Attributes[attr].Value;
            }
            return "";
        }

        private void LoadStyle()
        {
            string conf = Path.Combine(Application.StartupPath, "Conf", "scistyles.xml");
            if (File.Exists(conf))
            {
                XmlDocument doc = new XmlDocument();
                try
                {
                    doc.Load(conf);
                    XmlNode xstyles = doc.SelectSingleNode("Scintilla/LexerStyles");
                    if (xstyles != null && xstyles.HasChildNodes)
                    {
                        foreach (XmlNode xstyle in xstyles.ChildNodes)
                        {
                            if (xstyle.Name == "LexerType" && xstyle.Attributes["name"] != null && xstyle.Attributes["name"].Value == this.Lang && xstyle.HasChildNodes)
                            {
                                foreach (XmlNode xword in xstyle.ChildNodes)
                                {
                                    int id = 0;
                                    int c = 0;
                                    if (int.TryParse(this.GetAttr(xword, "styleID"), out id))
                                    {
                                        if (int.TryParse(this.GetAttr(xword, "fgColor"), System.Globalization.NumberStyles.HexNumber, null, out c))
                                            this.Styles[id].ForeColor = Color.FromArgb(c);

                                        if (int.TryParse(this.GetAttr(xword, "bgColor"), System.Globalization.NumberStyles.HexNumber, null, out c))
                                            this.Styles[id].BackColor = Color.FromArgb(c);

                                        if (this.GetAttr(xword, "fontName") != "")
                                        {
                                            this.Styles[id].Font = this.GetAttr(xword, "fontName");
                                        }

                                        if (int.TryParse(this.GetAttr(xword, "fontStyle"), out c))
                                        {
                                            this.Styles[id].Bold = (c & 1) == 1;

                                        }
                                        if (int.TryParse(this.GetAttr(xword, "fontSize"), out c))
                                        {
                                            this.Styles[id].Size = c;
                                        }

                                        if (this.GetAttr(xstyle, "keywordClass") != "")
                                        {

                                        }

                                    }
                                }
                            }

                        }
                    }
                }
                catch
                { }
                finally
                {
                    doc = null;
                }
            }
        }

        private void LoadLang()
        {
            string conf = Path.Combine(Application.StartupPath, "Conf", "scilang.xml");
            if (File.Exists(conf))
            {
                XmlDocument doc = new XmlDocument();
                try
                {
                    doc.Load(conf);
                    XmlNode xstyles = doc.SelectSingleNode("Scintilla/Languages");
                    if (xstyles != null && xstyles.HasChildNodes)
                    {
                        foreach (XmlNode xstyle in xstyles.ChildNodes)
                        {
                            if (xstyle.Name == "Language" && xstyle.Attributes["name"] != null && xstyle.Attributes["name"].Value == this.Lang && xstyle.HasChildNodes)
                            {
                                int id = 0;

                                this.CommentLine = this.GetAttr(xstyle, "commentLine");
                                this.CommentStart = this.GetAttr(xstyle, "commentStart");
                                this.CommentEnd = this.GetAttr(xstyle, "commentEnd");

                                foreach (XmlNode xword in xstyle.ChildNodes)
                                {
                                    if (xword.Name == "Keywords")
                                    {
                                        this.SetKeywords(id++, xword.InnerText);
                                    }
                                }
                                return;
                            }
                        }
                    }
                }
                catch
                { }
                finally
                {
                    doc = null;
                }
            }
        }

        public void SetLang()
        {
            this.EolMode = Eol.Lf;
            this.StyleResetDefault();
            this.Styles[Style.Default].Font = "Consolas";
            this.Styles[Style.Default].Size = Properties.Settings.Default.fontsize;
            this.StyleClearAll();

            //括号高亮
            this.Styles[Style.BraceLight].BackColor = Color.LightGray;
            this.Styles[Style.BraceLight].ForeColor = Color.BlueViolet;
            this.Styles[Style.BraceBad].ForeColor = Color.Red;

            this.IndentWidth = 2;
            this.TabWidth = 2;
            this.IndentationGuides = IndentView.LookBoth;

            this.ExtraAscent = Properties.Settings.Default.ExtraAscent;
            this.ExtraDescent = Properties.Settings.Default.ExtraDescent;
            this.SetProperty("tab.timmy.whinge.level", "1");
            this.SetProperty("fold", "1");

            this.Margins[0].Width = 42;

            this.Margins[2].Type = MarginType.Symbol;
            this.Margins[2].Mask = Marker.MaskFolders;
            this.Margins[2].Sensitive = true;
            this.Margins[2].Width = 20;

            for (int i = Marker.FolderEnd; i <= Marker.FolderOpen; i++)
            {
                this.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                this.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            this.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            this.Markers[Marker.Folder].SetBackColor(SystemColors.ControlText);
            this.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            this.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            this.Markers[Marker.FolderEnd].SetBackColor(SystemColors.ControlText);
            this.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            this.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            this.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            this.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            this.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

            this.LoadStyle();
            this.LoadLang();
        }

        public void SetDefault()
        {
            this.EolMode = Eol.Lf;
            this.StyleResetDefault();
            this.Styles[Style.Default].Font = "Consolas";
            this.Styles[Style.Default].Size = Properties.Settings.Default.fontsize;
            this.StyleClearAll(); // i.e. Apply to all

            this.ExtraAscent = Properties.Settings.Default.ExtraAscent;
            this.ExtraDescent = Properties.Settings.Default.ExtraDescent;

            this.SetProperty("tab.timmy.whinge.level", "1");
            this.SetProperty("fold", "1");

            this.Margins[0].Width = 42;

            this.Margins[2].Type = MarginType.Symbol;
            this.Margins[2].Mask = Marker.MaskFolders;
            this.Margins[2].Sensitive = true;
            this.Margins[2].Width = 20;

            for (int i = Marker.FolderEnd; i <= Marker.FolderOpen; i++)
            {
                this.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                this.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            this.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            this.Markers[Marker.Folder].SetBackColor(SystemColors.ControlText);
            this.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            this.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            this.Markers[Marker.FolderEnd].SetBackColor(SystemColors.ControlText);
            this.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            this.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            this.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            this.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            this.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

        }

        private void InsertMatchedChars(CharAddedEventArgs e)
        {
            var caretPos = this.CurrentPosition;
            var docStart = caretPos == 1;
            var docEnd = caretPos == this.Text.Length;

            var charPrev = docStart ? this.GetCharAt(caretPos) : this.GetCharAt(caretPos - 2);
            var charNext = this.GetCharAt(caretPos);

            var isCharPrevBlank = charPrev == ' ' || charPrev == '\t' ||
                                  charPrev == '\n' || charPrev == '\r';

            var isCharNextBlank = charNext == ' ' || charNext == '\t' ||
                                  charNext == '\n' || charNext == '\r' ||
                                  docEnd;

            var isEnclosed = (charPrev == '(' && charNext == ')') ||
                                  (charPrev == '{' && charNext == '}') ||
                                  (charPrev == '[' && charNext == ']');

            var isSpaceEnclosed = (charPrev == '(' && isCharNextBlank) || (isCharPrevBlank && charNext == ')') ||
                                  (charPrev == '{' && isCharNextBlank) || (isCharPrevBlank && charNext == '}') ||
                                  (charPrev == '[' && isCharNextBlank) || (isCharPrevBlank && charNext == ']');

            var isCharOrString = (isCharPrevBlank && isCharNextBlank) || isEnclosed || isSpaceEnclosed;

            var charNextIsCharOrString = charNext == '"' || charNext == '\'';

            switch (e.Char)
            {
                case '(':
                    if (charNextIsCharOrString) return;
                    this.InsertText(caretPos, ")");
                    break;
                case '{':
                    if (charNextIsCharOrString) return;
                    this.InsertText(caretPos, "}");
                    break;
                case '[':
                    if (charNextIsCharOrString) return;
                    this.InsertText(caretPos, "]");
                    break;
                case '"':
                    // 0x22 = "
                    if (charPrev == 0x22 && charNext == 0x22)
                    {
                        this.DeleteRange(caretPos, 1);
                        this.GotoPosition(caretPos);
                        return;
                    }

                    if (isCharOrString)
                        this.InsertText(caretPos, "\"");
                    break;
                case '\'':
                    // 0x27 = '
                    if (charPrev == 0x27 && charNext == 0x27)
                    {
                        this.DeleteRange(caretPos, 1);
                        this.GotoPosition(caretPos);
                        return;
                    }

                    if (isCharOrString)
                        this.InsertText(caretPos, "'");
                    break;
            }
        }
        private void ExScintilla_CharAdded(object sender, CharAddedEventArgs e)
        {
            if (Properties.Settings.Default.InsertMatchedChars)
            {
                InsertMatchedChars(e);
            }
            
            // Find the word start
            int currentPos = this.CurrentPosition;
            int wordStartPos = this.WordStartPosition(currentPos, true);
            string cirrentxt = this.GetTextRange(currentPos, wordStartPos);
           
            List<string> s = new List<string>();
            s.AddRange("ACCEL_X|ACCEL_Y|ACCEL_Z|ADC|ADCWiPy|AF_INET|AF_INET6|ALTITUDE|ARRAY|AbstractBlockDev|AbstractNIC|AssertionError|AttributeError|BIG_ENDIAN|BLE|BytesIO|CAN.BUS_OFF|CAN.ERROR_ACTIVE|CAN.ERROR_PASSIVE|CAN.ERROR_WARNING|CAN.LIST16|CAN.LIST32|CAN.LOOPBACK|CAN.MASK16|CAN.MASK32|CAN.NORMAL|CAN.SILENT|CAN.SILENT_LOOPBACK|CAN.STOPPED|CC3K|CC3K.WEP|CC3K.WPA|CC3K.WPA2|CPython|CircuitPython|Collector|DEBUG|DESC|DIE_TEMP|DecompIO|DiskAccess|Event|Exception|ExtInt.IRQ_FALLING|ExtInt.IRQ_RISING|ExtInt.IRQ_RISING_FALLING|FFI|FLOAT32|FLOAT64|FileIO|Flash|FlashArea|FrameBuffer|GPIO|GYRO_X|GYRO_Y|GYRO_Z|Garbage|HEAP_DATA|HEAP_EXEC|HUMIDITY|I2C|I2C.CONTROLLER|I2C.PERIPHERAL|I2S|I2S.MONO|I2S.RX|I2S.STEREO|I2S.TX|INCL|INT16|INT32|INT64|INT8|IPPROTO_SEC|IPPROTO_TCP|IPPROTO_UDP|ImportError|IndexError|KeyError|KeyboardInterrupt|LCD160CR|LCD160CR.h|LCD160CR.w|LIGHT|LITTLE_ENDIAN|Lock|Loop|MAGN_X|MAGN_Y|MAGN_Z|MCU|MICROPYINSPECT|MICROPYPATH|MemoryError|MicroPython|NATIVE|NVS|NameError|NeoPixel|NotImplementedError|OSError|OrderedDict()|PIO|PIO.IN_HIGH|PIO.IN_LOW|PIO.IRQ_SM0|PIO.IRQ_SM1|PIO.IRQ_SM2|PIO.IRQ_SM3|PIO.JOIN_NONE|PIO.JOIN_RX|PIO.JOIN_TX|PIO.OUT_HIGH|PIO.OUT_LOW|PIO.SHIFT_LEFT|PIO.SHIFT_RIGHT|PIOASMError|PRESS|PROX|PTR|PWM|Partition|Partition.BOOT|Partition.RUNNING|Partition.TYPE_APP|Partition.TYPE_DATA|Pin|Pin.AF_OD|Pin.AF_PP|Pin.ALT|Pin.ALT_OPEN_DRAIN|Pin.ANALOG|Pin.HIGH_POWER|Pin.IN|Pin.IRQ_FALLING|Pin.IRQ_HIGH_LEVEL|Pin.IRQ_LOW_LEVEL|Pin.IRQ_RISING|Pin.LOW_POWER|Pin.MED_POWER|Pin.OPEN_DRAIN|Pin.OUT|Pin.OUT_OD|Pin.OUT_PP|Pin.PULL_DOWN|Pin.PULL_HOLD|Pin.PULL_NONE|Pin.PULL_UP|REPL|RMT|RTC|RTC.ALARM0|RuntimeError|SD|SDCard|SOCK_DGRAM|SOCK_STREAM|SPI|SPI.CONTROLLER|SPI.LSB|SPI.MSB|SPI.PERIPHERAL|Sensor|Server|Signal|SoftI2C|SoftSPI|StateMachine|StopIteration|Stream|StringIO|SyntaxError|SystemExit|Task|TextIOWrapper|ThreadSafeFlag|Timer|Timer.A|Timer.B|Timer.MATCH|Timer.NEGATIVE|Timer.ONE_SHOT|Timer.PERIODIC|Timer.POSITIVE|Timer.PWM|Timer.TIMEOUT|TimerWiPy|TimerWiPy.ONE_SHOT|TimerWiPy.PERIODIC|TypeError|UART|UART.CTS|UART.RTS|UART.RX_ANY|UINT16|UINT32|UINT64|UINT8|ULP|USB_VCP.CTS|USB_VCP.IRQ_RX|USB_VCP.RTS|UUID|Unix|VOID|ValueError|VfsFat|VfsLfs1|VfsLfs2|WDT|WIZNET5K|WLAN|WLANWiPy|WLANWiPy.AP|WLANWiPy.EXT_ANT|WLANWiPy.INT_ANT|WLANWiPy.STA|WLANWiPy.WEP|WLANWiPy.WPA|WLANWiPy.WPA2|ZeroDivisionError|__call__()|__contains__()|__delitem__()|__getitem__()|__init__()|__iter__()|__len__()|__setitem__()|__str__()|_thread|a2b_base64()|abs()|abstract|accept()|acos()|acosh()|acquire()|active()|adcchannel()|add_program()|addressof()|aes|af()|af_list()|aiter()|alarm()|alarm_left()|all()|alloc_emergency_exception_buf()|alt_list()|anext()|angle()|antenna()|any()|append()|argv|array|as|ascii()|asin()|asinh()|asm_pio()|asm_pio_encode()|atan()|atan2()|atanh()|atexit()|atten()|auth()|b2a_base64()|baremetal|base|bin()|binascii|bind()|bitstream()|blit()|bluetooth|board|bool|bool()|bootloader()|break|breakpoint()|btree|buffer|built-in|bytearray|bytearray()|bytearray_at()|bytecode|byteorder|bytes|bytes()|bytes_at()|calcsize()|calibration()|call_exception_handler()|callable()|callback()|callee-owned|cancel()|capture()|case|catch|ceil()|channel()|chdir()|checked|chr()|classmethod()|clear()|clearfilter()|clock_div()|close()|cmath|collect()|collections|command|command()|commit()|compare()|compile()|complex|complex()|config()|connect()|const()|continue|contrast()|copysign()|cos()|cosh()|counter()|create_task()|cross-compiler|cryptolib|current_task()|current_tid()|datetime()|debug()|decompress()|decrypt()|deepsleep()|default|default_exception_handler()|degrees()|deinit()|delattr()|delay()|delegate|deque()|dict|dict()|digest()|dir()|disable()|disable_irq()|disconnect()|divmod()|do|dot()|dot_no_clip()|drain()|drive()|driver|dump()|dumps()|dupterm()|duty_cycle()|duty_ns()|duty_u16()|elapsed_micros()|elapsed_millis()|else|enable()|enable_irq()|encrypt()|end()|enumerate()|environment|erase()|erase_key()|erf()|erfc()|errno|errorcode|esp|esp32|esp32.WAKEUP_ALL_LOW|esp32.WAKEUP_ANY_HIGH|eval()|event|exec()|exit()|exp()|explicit|expm1()|extend()|extern|fabs()|false|fast_spi()|fault_debug()|feed()|feed_wdt()|filesystem|fill()|fill_rect()|filter()|filtered_xyz()|finally|find()|fixed|flash_erase()|flash_id()|flash_read()|flash_size()|flash_user_start()|flash_write()|float|float()|floor()|flush()|fmod()|for|foreach|format()|framebuf|framebuf.GS2_HMSB|framebuf.GS4_HMSB|framebuf.GS8|framebuf.MONO_HLSB|framebuf.MONO_HMSB|framebuf.MONO_VLSB|framebuf.RGB565|freq()|frexp()|from_bytes()|frozen|frozenset|frozenset()|function|gamma()|gap_advertise()|gap_connect()|gap_disconnect()|gap_pair()|gap_passkey()|gap_scan()|gather()|gattc_discover_characteristics()|gattc_discover_descriptors()|gattc_discover_services()|gattc_exchange_mtu()|gattc_read()|gattc_write()|gatts_indicate()|gatts_notify()|gatts_read()|gatts_register_services()|gatts_set_buffer()|gatts_write()|gc|get()|get_blob()|get_event_loop()|get_exception_handler()|get_extra_info()|get_float()|get_i32()|get_int()|get_line()|get_micros()|get_millis()|get_next_update()|get_pixel()|get_touch()|getaddrinfo()|getattr()|getcwd()|getvalue()|globals()|gmtime()|goto|gpio()|group()|groups()|hall_sensor()|hard_reset()|hasattr()|hash()|hashlib|hashlib.md5|hashlib.sha1|hashlib.sha256|have_cdc()|heap|heap_lock()|heap_locked()|heap_unlock()|heapify()|heappop()|heappush()|heapq|heartbeat()|help()|hex()|hexdigest()|hexlify()|hid()|high()|hline()|id()|idf_heap_info()|idle()|if|ifconfig()|ilistdir()|implementation|implicit|import|in|index()|inet_ntop()|inet_pton()|info()|init()|initfilterbanks()|input()|int|int()|intensity()|interface|internal|interned|io|ioctl()|ipoll()|irq()|is|is_preempt_thread()|is_ready()|is_set()|is_touched()|isconnected()|isfinite()|isinf()|isinstance()|isnan()|isrunning()|issubclass()|items()|iter()|jpeg()|jpeg_data()|jpeg_start()|json|kbd_intr()|keys()|l2cap_connect()|l2cap_disconnect()|l2cap_listen()|l2cap_recvinto()|l2cap_send()|lcd160cr|lcd160cr.LANDSCAPE|lcd160cr.LANDSCAPE_UPSIDEDOWN|lcd160cr.PORTRAIT|lcd160cr.PORTRAIT_UPSIDEDOWN|lcd160cr.STARTUP_DECO_INFO|lcd160cr.STARTUP_DECO_MLOGO|lcd160cr.STARTUP_DECO_NONE|ldexp()|len()|lgamma()|light()|lightsleep()|line|line()|line_no_clip()|list|list()|listdir()|listen()|load()|load_binary()|loads()|locals()|localtime()|lock|locked()|log()|log10()|log2()|loop()|low()|mac()|machine|machine.DEEPSLEEP|machine.DEEPSLEEP_RESET|machine.HARD_RESET|machine.IDLE|machine.PIN_WAKE|machine.PWRON_RESET|machine.RTC_WAKE|machine.SLEEP|machine.SOFT_RESET|machine.WDT_RESET|machine.WLAN_WAKE|main()|makefile()|map()|mapper()|mark_app_valid_cancel_rollback()|match()|math|max()|maxsize|measure()|mem_alloc()|mem_free()|mem_info()|mem_read()|mem_write()|memoryview|memoryview()|micropython|micropython-lib|micros()|millis()|min()|mkdir()|mkfs()|mktime()|mode()|modf()|modify()|mount()|name()|namedtuple()|names()|namespace|native|neopixel|network|network.Server|new|new_event_loop()|next()|noise()|now()|null|object|object()|oct()|off()|on()|open()|open_connection()|operator|opt_level()|option|ord()|os|out|override|pack()|pack_into()|params|patch_program()|patch_version()|path|period()|phase()|phy_mode()|pi|pin()|pixel()|platform|polar()|poll()|poly_dot()|poly_line()|popleft()|port|port()|pow()|prescaler()|print()|print_exception()|private|property()|protected|protocol|public|pull()|pulse_width()|pulse_width_percent()|put()|pyb|pyb.ADC|pyb.Accel|pyb.CAN|pyb.DAC|pyb.ExtInt|pyb.Flash|pyb.I2C|pyb.LCD|pyb.LED|pyb.Pin|pyb.RTC|pyb.SPI|pyb.Servo|pyb.Switch|pyb.Timer|pyb.UART|pyb.USB_HID|pyb.USB_VCP|qstr_info()|radians()|range()|raw_temperature()|re|read()|read_timed()|read_timed_multi()|read_u16()|readblocks()|readchar()|readexactly()|readfrom()|readfrom_into()|readfrom_mem()|readfrom_mem_into()|readinto()|readline()|readlines()|readonly|rect()|rect_interior()|rect_interior_no_clip()|rect_no_clip()|rect_outline()|rect_outline_no_clip()|recv()|recvfrom()|ref|reg()|register()|regs()|release()|remove()|remove_program()|rename()|repl_uart()|repr()|reset()|reset_cause()|restart()|return|reversed()|rgb()|rmdir()|rng()|round()|rp2|run()|run_forever()|run_until_complete()|rx_fifo()|rxcallback()|save_to_flash()|scan()|schedule()|screen_dump()|screen_load()|scroll()|sealed|search()|select|select()|send()|send_recv()|sendall()|sendbreak()|sendto()|set|set()|set_blob()|set_boot()|set_brightness()|set_exception_handler()|set_font()|set_i2c_addr()|set_i32()|set_native_code_location()|set_orient()|set_pen()|set_pixel()|set_pos()|set_power()|set_scroll()|set_scroll_buf()|set_scroll_win()|set_scroll_win_param()|set_spi_win()|set_startup_deco()|set_text_color()|set_uart_baudrate()|set_wakeup_period()|setattr()|setblocking()|setfilter()|setinterrupt()|setsockopt()|settimeout()|shell_exec()|shift()|show()|show_framebuf()|sin()|sinh()|sizeof|sizeof()|sleep()|sleep_ms()|sleep_type()|sleep_us()|slice|slice()|slicea()|socket|socket()|socket.error|soft_reset()|sorted()|source_freq()|span()|speed()|split()|sqrt()|ssid()|ssl|ssl.CERT_NONE|ssl.CERT_OPTIONAL|ssl.CERT_REQUIRED|ssl.SSLError|ssl.wrap_socket()|stack_use()|stackalloc|standby()|start()|start_server()|stat()|state()|state_machine()|staticmethod()|status()|statvfs()|stderr|stdin|stdout|stop()|str|str()|stream|string|struct|sub()|sum()|super()|swint()|switch|sync()|sys|tan()|tanh()|text()|this|thread_analyze()|threshold()|throw|ticks_add()|ticks_cpu()|ticks_diff()|ticks_ms()|ticks_us()|tilt()|time|time()|time_ns()|time_pulse_us()|timeout()|to_bytes()|toggle()|touch_config()|triangle()|true|trunc()|try|tuple|tuple()|tx_fifo()|type()|typeof|uarray|uasyncio|ubinascii|ubluetooth|ucollections|ucryptolib|uctypes|udelay()|uerrno|uhashlib|uheapq|uio|ujson|umount()|uname()|unchecked|unhexlify()|unique_id()|unmount()|unpack()|unpack_from()|unregister()|unsafe|uos|update()|upip|urandom()|ure|usb_mode()|uselect|using|usocket|ussl|ustruct|usys|utime|uzlib|value()|values()|variable|vars()|version|version_info|virtual|vline()|wait()|wait_closed()|wait_done()|wait_for()|wait_for_ms()|wake_on_ext0()|wake_on_ext1()|wake_on_touch()|wake_reason()|wakeup()|wfi()|while|width()|wipy|write()|write_pulses()|write_readinto()|write_timed()|writeblocks()|writechar()|writeto()|writeto_mem()|writevto()|x()|y()|z()|zephyr|zip()|zlib|zsensor".Split('|'));
            

            // Display the autocompletion list
            int lenEntered = currentPos - wordStartPos;
            Console.WriteLine(lenEntered);
            if (lenEntered > 0)
            {
                string keytxt = this.Text.Substring(this.CurrentPosition - lenEntered, lenEntered); //获取当前关键字
                List<string> r = s.Where(x => x.Length > keytxt.Length && x.Substring(0, keytxt.Length).ToLower() == keytxt.ToLower()).ToList();  //过滤关键字
                r.Sort();
                this.AutoCShow(lenEntered, string.Join(" ", r));

                    

            }
            
            //var currentPos = this.CurrentPosition;
            //var wordStartPos = this.WordStartPosition(currentPos, true);

            //char c = this.Text[this.CurrentPosition-1];
            //// Display the autocompletion list
            //var lenEntered = currentPos - wordStartPos;
            //if (e.Char == ' ' && this.FCompletionForm != null)
            //{
            //    this.HideCompletions();
            //}
            //else if (e.Char == '(')
            //{
            //    Application.DoEvents();
            //    this.FindCompletions();

            //    if (this.Completions.Count == 1)
            //    {
            //        Completion comp = this.Completions[0];
            //    }
            //}
            //else if (e.Char == '.')
            //{
            //    Application.DoEvents();
            //    this.FindCompletions();
            //}
            //else if (this.FCompletionForm == null && lenEntered == 1)
            //{
            //    this.FindCompletions();
            //}
            //else if (this.FCompletionForm != null)
            //{
            //    this.SetFilter(0);
            //}
        }

        private void ExScintilla_Delete(object sender, ModificationEventArgs e)
        {
            //if (this.FCompletionForm != null)
            //{
            //    if (e.Text.Contains('.') || e.Text.Contains("(") || e.Text.Contains(")") || this.CurrentPosition < this.CompletionPosition)
            //    {
            //        this.HideCompletions();
            //    }
            //    else
            //    {
            //        this.SetFilter(0);
            //    }
            //}

        }

        private void ExScintilla_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void ExScintilla_Leave(object sender, EventArgs e)
        {
            //if (this.FCompletionForm != null && this.FCompletionForm.Visible)
            //    this.HideCompletions();
        }

        private void ExScintilla_MouseDown(object sender, MouseEventArgs e)
        {
            //if (this.FCompletionForm != null)
            //    this.HideCompletions();
        }

        private void ExScintilla_Resize(object sender, EventArgs e)
        {
            //if (this.FCompletionForm != null)
            //    this.HideCompletions();
        }

        private void ExScintilla_DwellEnd(object sender, DwellEventArgs e)
        {
            // Todo:
            //if (e.Position > 0)
            //{
            //    Line line = this.Lines[this.LineFromPosition(e.Position)];
            //    int sp = e.Position - line.Position;
            //    while (sp > 0)
            //    {
            //        if (line.Text[sp] == '.' || line.Text[sp] == '_' || char.IsLetterOrDigit(line.Text[sp]))
            //            sp--;
            //        else break;
            //    }

            //    int ep = e.Position - line.Position;
            //    while (ep < line.Text.Length)
            //    {
            //        if (line.Text[ep] == '.' || line.Text[ep] == '_' || char.IsLetterOrDigit(line.Text[ep]))
            //            ep++;
            //        else break;
            //    }
            //    if (ep > sp)
            //    {
            //        string w = line.Text.Substring(sp, ep - sp);
            //        Console.WriteLine(w);

                    
            //    }
            //}
        }

        private void ExScintilla_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    
