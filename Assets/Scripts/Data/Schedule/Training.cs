using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


sealed class Training:Action
{
    public int cost;//训练消耗
    public int level;//训练等级

    public Training()
    {

    }

    public Training(int id ,int type):base(id,type) 
    {

    }

    public sealed override void Do()
    {
        
    }
}

