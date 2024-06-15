using System.Drawing;
using Line.Messaging;
using Line.Messaging.Webhooks;

public class LineService : ILineService
{
    private int lastSelectedIndex = -1;
    public LineService()
    {
    }

    public async Task<List<ISendMessage>> ProcessTextEventMessageAsync(string channelId, string userId, string message)
    {
        var result = new List<ISendMessage>();
        if (message == "隨機變身")
        {
            string[] imageUrl = new string[]
            {
                "https://i.imgur.com/jJ8BZ6y.jpg",
                "https://i.imgur.com/cfsOyCP.jpg",
                "https://i.imgur.com/LPUMdTI.jpg",
                "https://i.imgur.com/ocFms7O.jpg",
                "https://i.imgur.com/gSxyf2B.jpg",
                "https://i.imgur.com/tevdtgJ.jpeg",
                "https://i.imgur.com/7f6mF9r.png",
                "https://i.imgur.com/BywTEUk.jpg",
                "https://i.imgur.com/lB6IEdY.jpg",
                "https://i.imgur.com/UvV8lPb.jpg",
                "https://i.imgur.com/qgzVNsq.jpg",
            };
            Random rnd = new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index;
            do
            {
                index = rnd.Next(0, imageUrl.Length);
            } while (index == lastSelectedIndex);
    
            lastSelectedIndex = index;
            var imageMessage = new ImageMessage(imageUrl[index], imageUrl[index]);
            result.Add(imageMessage);
            return result;
        }
        
        
        if (message == "作者資訊")
        {
            result = new List<ISendMessage>
            {
                new TextMessage("作者姓名 : 蔡閎安\n個人狀態 : 期末好累 要寄了🤢"),
                new ImageMessage("https://i.imgur.com/NscTPZK.png","https://i.imgur.com/NscTPZK.png",null)
            };
            return result;
        }
        if (message == "發明者介紹")
        {
            result = new List<ISendMessage>
            {
                new ImageMessage("https://i.imgur.com/YO9M2SU.png","https://i.imgur.com/YO9M2SU.png",null),
                new TextMessage("開發者 : 阿茲米斯\n品種 : 蓋文星人\nOmnitrix發明者"),
            };
            return result;
        }
        if (message == "沼澤火")
        {
            result = new List<ISendMessage>
            {
                new ImageMessage("https://i.imgur.com/cfsOyCP.jpg","https://i.imgur.com/cfsOyCP.jpg",null),
                new TextMessage("你變身成了沼澤火"),
            };
            return result;
        }
        if (message == "寒冰幽靈")
        {
            result = new List<ISendMessage>
            {
                new ImageMessage("https://i.imgur.com/LPUMdTI.jpg","https://i.imgur.com/LPUMdTI.jpg",null),
                new TextMessage("你變身成了寒冰幽靈"),
            };
            return result;
        }
        if (message == "魟人")
        {
            result = new List<ISendMessage>
            {
                new ImageMessage("https://i.imgur.com/ocFms7O.jpg","https://i.imgur.com/ocFms7O.jpg",null),
                new TextMessage("你變身成了魟人"),
            };
            return result;
        }
        if (message == "蟹甲智多星")
        {
            result = new List<ISendMessage>
            {
                new ImageMessage("https://i.imgur.com/jJ8BZ6y.jpg","https://i.imgur.com/jJ8BZ6y.jpg",null),
                new TextMessage("你變身成了蟹甲智多星"),
            };
            return result;
        }
        if (message == "小波波")
        {
            result = new List<ISendMessage>
            {
                new ImageMessage("https://i.imgur.com/tevdtgJ.jpeg","https://i.imgur.com/tevdtgJ.jpeg",null),
                new TextMessage("你變身成了小波波"),
            };
            return result;
        }
        if (message == "蜘蛛魔猴")
        {
            result = new List<ISendMessage>
            {
                new ImageMessage("https://i.imgur.com/BywTEUk.jpg","https://i.imgur.com/BywTEUk.jpg",null),
                new TextMessage("你變身成了蜘蛛魔猴"),
            };
            return result;
        }
        if (message == "異形怪")
        {
            result = new List<ISendMessage>
            {
                new ImageMessage("https://i.imgur.com/7f6mF9r.png","https://i.imgur.com/7f6mF9r.png",null),
                new TextMessage("你變身成了異形怪"),
            };
            return result;
        }
        if (message == "水晶奇俠")
        {
            result = new List<ISendMessage>
            {
                new ImageMessage("https://i.imgur.com/lB6IEdY.jpg","https://i.imgur.com/lB6IEdY.jpg",null),
                new TextMessage("你變身成了水晶奇俠"),
            };
            return result;
        }
        if (message == "神力暴龍")
        {
            result = new List<ISendMessage>
            {
                new ImageMessage("https://i.imgur.com/UvV8lPb.jpg","https://i.imgur.com/UvV8lPb.jpg",null),
                new TextMessage("你變身成了神力暴龍"),
            };
            return result;
        }
        if (message == "X超人")
        {
            result = new List<ISendMessage>
            {
                new ImageMessage("https://i.imgur.com/qgzVNsq.jpg","https://i.imgur.com/qgzVNsq.jpg",null),
                new TextMessage("你變身成了X超人"),
            };
            return result;
        }
        if (message == "X超人")
        {
            result = new List<ISendMessage>
            {
                new ImageMessage("https://i.imgur.com/qgzVNsq.jpg","https://i.imgur.com/qgzVNsq.jpg",null),
                new TextMessage("你變身成了X超人"),
            };
            return result;
        }
        if (message == "超巨人")
        {
            result = new List<ISendMessage>
            {
                new ImageMessage("https://i.imgur.com/gSxyf2B.jpg","https://i.imgur.com/gSxyf2B.jpg",null),
                new TextMessage("你變身成了超巨人"),
            };
            return result;
        }
        result = new List<ISendMessage>
        {
            new TextMessage("我不知道你說什麼😜")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessStickerEventMessageAsync(string channelId, string userId,string packageId, string stickerId)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage("我不知道你說什麼😜")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId,string originalContentUrl,
        string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage("我不知道你說什麼😜")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId, Image image)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage("我不知道你什麼😜")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessVideoEventMessageAsync(string channelId, string userId,string originalContentUrl, string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a video event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessAudioEventMessageAsync(string channelId, string userId,string originalContentUrl, int duration)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a audio event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessLocationEventMessageAsync(string channelId, string userId,string title, string address, float latitude, float longitude)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage("我不知道你說什麼😜")
        };
        return result;
    }
}