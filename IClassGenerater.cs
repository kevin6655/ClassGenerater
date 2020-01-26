using System;
using System.Collections.Generic;
using System.Text;

namespace ClassGenerater
{
    interface IClassGenerater
    {/// <summary>
    /// ファイルを生成する処理
    /// </summary>
    /// <returns></returns>
        public string GeneraterCodeFile();

        public void AddProperty();

    }
}
