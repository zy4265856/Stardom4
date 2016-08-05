using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Action
{
    public int id;//全局唯一的行为ID，详细内容根据id索引配表所得
    public int type;//行为类别
    public int length;//行为消耗时长
    public uint length_type;//行为时长类别，1上午，2为下午，3为上午和下午，4为晚上，5为上午和晚上，6为下午和晚上，7为上午下午和晚上，其他无效

    public Action()
    { }

    public Action(int id, int type)
    {
        this.id = id;
        this.type = type;
    }

    public abstract void Do();
}
