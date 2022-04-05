using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Gtk;


public class Request {
    public string URL { get; set; }
    private string Headers { get; set; }

    public Request(string _URL) {
        this.URL = _URL;
    }
}

public class Response {
    public string data;
    public string status;

    public Response() {
        this.data = "";
        this.status = "";
    }

    public Response(string _data, string _status) {
        this.data = _data;
        this.status = SetStatus(_status);
    }

    private string SetStatus(string _status) {
        return "Status: " + _status;
    }

}

public class REST {
    static readonly HttpClient client = new HttpClient();

    public async Task<Response> Get(string URL) {
        Response res;
        try {
            HttpResponseMessage response = await client.GetAsync(URL);
            response.EnsureSuccessStatusCode();
            string responseData = await response.Content.ReadAsStringAsync();
            res = new Response(JToken.Parse(responseData).ToString(Formatting.Indented), response.StatusCode.ToString());

        } catch (HttpRequestException error) {
            res = new Response(error.Message, "Error");
        }

        return res;
    }

    public async Task<Response> Post(string URL, string data) {
        Response res;
        try {
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(URL, content);
            response.EnsureSuccessStatusCode();
            string responseData = await response.Content.ReadAsStringAsync();
            res = new Response(JToken.Parse(responseData).ToString(Formatting.Indented), response.StatusCode.ToString());
        } catch (HttpRequestException error) {
            res = new Response(error.Message, "Error");
        }

        return res;
    }
}

public partial class MainWindow : Gtk.Window {
    static readonly REST rest = new REST();
    private bool isRequestSafe = false;

    public MainWindow() : base(Gtk.WindowType.Toplevel) {
        Build();

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a) {
        Application.Quit();
        a.RetVal = true;
    }

    protected async void OnSendRequesetButtonClicked(object sender, EventArgs e) {
        string method = RequestTypeComboBox.ActiveText;
        string protocol = isRequestSafe ? "https://" : "http://";
        string path = UrlEntry.Text;
        string requestData = RequestDataTextView.Buffer.Text;

        Response res = new Response();

        switch (method) {
            case "GET":
                res = await rest.Get(protocol + path);
                break;
            case "POST":
                res = await rest.Post(protocol + path, requestData);
                break;
        }

        ResponseDataTextView.Buffer.Text = res.data;
        StatusLabel.Text = res.status;
        StatusLabel.ModifyFg(StateType.Normal, new Gdk.Color(255, 255, 255));
    }

    protected void OnImageEventBoxButtonPressEvent(object o, ButtonPressEventArgs args) {
        if (isRequestSafe) {
            SslImage.Pixbuf = RenderIcon("unsafe", IconSize.Button, "");
        } else {
            SslImage.Pixbuf = RenderIcon("safe", IconSize.Button, "");
        }
        isRequestSafe = !isRequestSafe;
    }
}
