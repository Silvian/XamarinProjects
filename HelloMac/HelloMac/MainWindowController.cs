
using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;

namespace HelloMac
{
	public partial class MainWindowController : MonoMac.AppKit.NSWindowController

	{
		#region Global Variables

		//Global variable containing value to be calculated.
		String inputValue = "";
		String totalValue = "";

		#endregion

		#region Constructors
		
		// Called when created from unmanaged code
		public MainWindowController (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public MainWindowController (NSCoder coder) : base (coder)
		{
			Initialize ();
		}
		
		// Call to load from the XIB/NIB file
		public MainWindowController () : base ("MainWindow")
		{
			Initialize ();
		}
		
		// Shared initialization code
		void Initialize ()
		{
		}
		
		#endregion
		
		//strongly typed window accessor
		public new MainWindow Window {
			get {
				return (MainWindow)base.Window;
			}
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();
			OKButton.Activated += CalculateHandleActivated;
			TextField.Activated += InputHandleActivated;
			CancelButton.Activated += CancelHandleActivated;


		}

		void CancelHandleActivated (object sender, EventArgs e)
		{
			NSApplication.SharedApplication.Terminate (null);
		
		}

		void InputHandleActivated(object sender, EventArgs e)
		{

		}

		void CalculateHandleActivated (object sender, EventArgs e)
		{
			String temp;
			temp = TextField.StringValue;
			
			
			inputValue = temp;
			temp = null;


			totalValue = inputValue.ToUpper();
			TextField.StringValue = totalValue;

		}

	}
}

