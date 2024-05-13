namespace MyWeb.Data;

public class NPCitem
{
    public string url { get; set; }
    public string msg { get; set; }

    public NPCitem(string url, string msg)
    {
        this.url = url;
        this.msg = msg;
    }
}