using System;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace VoiceClicker
{
	public partial class VoiceClickerForm : Form
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Winapi)]
		public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

		private const int MOUSEEVENTF_LEFTDOWN = 0x2;
		private const int MOUSEEVENTF_LEFTUP = 0x4;


		[DllImport("user32.dll")]
		private static extern uint keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

		private const int KEYEVENTF_KEYDOWN = 0x0;
		private const int KEYEVENTF_KEYUP = 0x2;

		private static SpeechRecognizer rec = new SpeechRecognizer();

		public VoiceClickerForm()
		{
			InitializeComponent();

			rec.Enabled = true;

			// doesn't work fine (Michael Krisper)
			//var ch = new Choices(new[] {"Klick", "Doppelklick"});
			//var gb = new GrammarBuilder(ch);
			//var g = new Grammar(gb);
			//rec.LoadGrammar(g);


			//rec.SpeechDetected += DoMouseClick;
			rec.SpeechDetected += PressKeyboardButton;

			rec.SpeechRecognized += rec_SpeechRecognized;
		}

		private void rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
		{
			Console.WriteLine("Detected: {0}", e.Result);
		}

		private void PressKeyboardButton(object sender, SpeechDetectedEventArgs e)
		{
			//var key = (byte) Keys.RControlKey;
			var key = (byte) 'A';

			keybd_event(key, 0, KEYEVENTF_KEYDOWN, 0);
			keybd_event(key, 0, KEYEVENTF_KEYUP, 0);

			Console.WriteLine("[{0}] Pressed Key: {1}.", e.AudioPosition, key);
			lblInputTime.Text = e.AudioPosition.ToString();
		}

		private void DoMouseClick(object sender, SpeechDetectedEventArgs e)
		{
			var x = Cursor.Position.X;
			var y = Cursor.Position.Y;
			mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0L, 0L);
			Console.WriteLine("[{0}] Clicked on: x={1}, y={2}", e.AudioPosition, x, y);
			lblInputTime.Text = e.AudioPosition.ToString();
		}
	}
}