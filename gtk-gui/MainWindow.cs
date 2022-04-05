
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.VBox vbox1;

	private global::Gtk.MenuBar MenuBar;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Alignment alignment1;

	private global::Gtk.HPaned hpaned2;

	private global::Gtk.VBox vbox2;

	private global::Gtk.ComboBox RequestTypeComboBox;

	private global::Gtk.HBox hbox2;

	private global::Gtk.EventBox SslImageEventBox;

	private global::Gtk.Image SslImage;

	private global::Gtk.Entry UrlEntry;

	private global::Gtk.Frame frame2;

	private global::Gtk.Alignment GtkAlignment1;

	private global::Gtk.ScrolledWindow GtkScrolledWindow1;

	private global::Gtk.TextView RequestDataTextView;

	private global::Gtk.Label BodyDataLabel;

	private global::Gtk.Button SendRequestButton;

	private global::Gtk.Frame frame1;

	private global::Gtk.Alignment GtkAlignment;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView ResponseDataTextView;

	private global::Gtk.Label ResponseDataLabel;

	private global::Gtk.Statusbar StatusBar;

	private global::Gtk.Label StatusLabel;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name=\'MenuBar\'/></ui>");
		this.MenuBar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/MenuBar")));
		this.MenuBar.Name = "MenuBar";
		this.vbox1.Add(this.MenuBar);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.MenuBar]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
		this.alignment1.Name = "alignment1";
		// Container child alignment1.Gtk.Container+ContainerChild
		this.hpaned2 = new global::Gtk.HPaned();
		this.hpaned2.CanFocus = true;
		this.hpaned2.Name = "hpaned2";
		this.hpaned2.Position = 275;
		// Container child hpaned2.Gtk.Paned+PanedChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.RequestTypeComboBox = global::Gtk.ComboBox.NewText();
		this.RequestTypeComboBox.AppendText(global::Mono.Unix.Catalog.GetString("GET"));
		this.RequestTypeComboBox.AppendText(global::Mono.Unix.Catalog.GetString("POST"));
		this.RequestTypeComboBox.AppendText(global::Mono.Unix.Catalog.GetString("PUT"));
		this.RequestTypeComboBox.AppendText(global::Mono.Unix.Catalog.GetString("DELETE"));
		this.RequestTypeComboBox.Name = "RequestTypeComboBox";
		this.RequestTypeComboBox.Active = 0;
		this.vbox2.Add(this.RequestTypeComboBox);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.RequestTypeComboBox]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.SslImageEventBox = new global::Gtk.EventBox();
		this.SslImageEventBox.Name = "SslImageEventBox";
		// Container child SslImageEventBox.Gtk.Container+ContainerChild
		this.SslImage = new global::Gtk.Image();
		this.SslImage.Name = "SslImage";
		this.SslImage.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "stock_lock-open", global::Gtk.IconSize.Menu);
		this.SslImageEventBox.Add(this.SslImage);
		this.hbox2.Add(this.SslImageEventBox);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.SslImageEventBox]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.UrlEntry = new global::Gtk.Entry();
		this.UrlEntry.CanFocus = true;
		this.UrlEntry.Name = "UrlEntry";
		this.UrlEntry.IsEditable = true;
		this.UrlEntry.InvisibleChar = '•';
		this.hbox2.Add(this.UrlEntry);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.UrlEntry]));
		w6.Position = 1;
		this.vbox2.Add(this.hbox2);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.frame2 = new global::Gtk.Frame();
		this.frame2.Name = "frame2";
		this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.RequestDataTextView = new global::Gtk.TextView();
		this.RequestDataTextView.CanFocus = true;
		this.RequestDataTextView.Name = "RequestDataTextView";
		this.GtkScrolledWindow1.Add(this.RequestDataTextView);
		this.GtkAlignment1.Add(this.GtkScrolledWindow1);
		this.frame2.Add(this.GtkAlignment1);
		this.BodyDataLabel = new global::Gtk.Label();
		this.BodyDataLabel.Name = "BodyDataLabel";
		this.BodyDataLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Request Data");
		this.frame2.LabelWidget = this.BodyDataLabel;
		this.vbox2.Add(this.frame2);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.frame2]));
		w11.Position = 2;
		// Container child vbox2.Gtk.Box+BoxChild
		this.SendRequestButton = new global::Gtk.Button();
		this.SendRequestButton.CanFocus = true;
		this.SendRequestButton.Name = "SendRequestButton";
		this.SendRequestButton.UseUnderline = true;
		this.SendRequestButton.Label = global::Mono.Unix.Catalog.GetString("SEND");
		this.vbox2.Add(this.SendRequestButton);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.SendRequestButton]));
		w12.Position = 3;
		w12.Expand = false;
		w12.Fill = false;
		this.hpaned2.Add(this.vbox2);
		global::Gtk.Paned.PanedChild w13 = ((global::Gtk.Paned.PanedChild)(this.hpaned2[this.vbox2]));
		w13.Resize = false;
		// Container child hpaned2.Gtk.Paned+PanedChild
		this.frame1 = new global::Gtk.Frame();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.ResponseDataTextView = new global::Gtk.TextView();
		this.ResponseDataTextView.CanFocus = true;
		this.ResponseDataTextView.Name = "ResponseDataTextView";
		this.GtkScrolledWindow.Add(this.ResponseDataTextView);
		this.GtkAlignment.Add(this.GtkScrolledWindow);
		this.frame1.Add(this.GtkAlignment);
		this.ResponseDataLabel = new global::Gtk.Label();
		this.ResponseDataLabel.Name = "ResponseDataLabel";
		this.ResponseDataLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Response data");
		this.frame1.LabelWidget = this.ResponseDataLabel;
		this.hpaned2.Add(this.frame1);
		this.alignment1.Add(this.hpaned2);
		this.hbox1.Add(this.alignment1);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.alignment1]));
		w19.Position = 0;
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w20.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.StatusBar = new global::Gtk.Statusbar();
		this.StatusBar.Name = "StatusBar";
		this.StatusBar.Spacing = 6;
		// Container child StatusBar.Gtk.Box+BoxChild
		this.StatusLabel = new global::Gtk.Label();
		this.StatusLabel.Name = "StatusLabel";
		this.StatusLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Status: N/A");
		this.StatusBar.Add(this.StatusLabel);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.StatusBar[this.StatusLabel]));
		w21.Position = 2;
		w21.Expand = false;
		w21.Fill = false;
		this.vbox1.Add(this.StatusBar);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.StatusBar]));
		w22.Position = 2;
		w22.Expand = false;
		w22.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 596;
		this.DefaultHeight = 377;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.SslImageEventBox.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler(this.OnImageEventBoxButtonPressEvent);
		this.SendRequestButton.Clicked += new global::System.EventHandler(this.OnSendRequesetButtonClicked);
	}
}
