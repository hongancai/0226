﻿namespace MyWeb.Models;

public class AlienModel
{
    public int Id;
    public string userdata;
    public string Type;
    public string Name;
}

public static class AlienModelFakeDB
{
    public static Dictionary<string, AlienModel> _dictionary = new Dictionary<string, AlienModel>();

    static AlienModelFakeDB()
    {
        _dictionary.Add("A01",new AlienModel()
        {
            Id=1,
            userdata = "A01",
            Type = "梅沙火星人",
            Name = "沼澤火",
        });
        _dictionary.Add("A02",new AlienModel()
            {
                Id=2,
                userdata = "A02",
                Type = "變形外星人",
                Name = "異形怪",
            }
        );
        _dictionary.Add("A03",new AlienModel()
            {
                Id=3,
                userdata = "A03",
                Type = "海空雙棲星人",
                Name = "魟人",
            }
        );
        _dictionary.Add("A04",new AlienModel()
            {
                Id=4,
                userdata = "A04",
                Type = "索諾波波星人",
                Name = "小波波",
            }
        );
        _dictionary.Add("A05",new AlienModel()
            {
                Id=5,
                userdata = "A05",
                Type = "蟹甲布洛卡特斯星人",
                Name = "蟹甲智多星",
            }
        );
        _dictionary.Add("A06",new AlienModel()
            {
                Id=6,
                userdata = "A06",
                Type = "瓦克斯薩瑞人",
                Name = "神力暴龍",
            }
        );
        _dictionary.Add("A07",new AlienModel()
            {
                Id=7,
                userdata = "A07",
                Type = "佩卓沙皮星人",
                Name = "水晶奇俠",
            }
        );
        _dictionary.Add("A08",new AlienModel()
            {
                Id=8,
                userdata = "A08",
                Type = "納克佛吉星人",
                Name = "寒冰幽靈",
            }
        );
        _dictionary.Add("A09",new AlienModel()
            {
                Id=9,
                userdata = "A09",
                Type = "阿拉卡那星人",
                Name = "蜘蛛魔猴",
            }
        );
        _dictionary.Add("A10",new AlienModel()
            {
                Id=10,
                userdata = "A10",
                Type = "天外天神族",
                Name = "X超人",
            }
        );
        _dictionary.Add("A11",new AlienModel()
            {
                Id=11,
                userdata = "A11",
                Type = "圖庫斯塔人",
                Name = "超巨人",
            }
        );
    }
        
}