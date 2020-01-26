using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.CodeDom;
using System.CodeDom.Compiler;
using Microsoft.CSharp;


namespace ClassGenerater
{/// <summary>
/// ファイルを生成するクラス
/// ■　参考元：https://docs.microsoft.com/ja-jp/dotnet/framework/reflection-and-codedom/how-to-create-a-class-using-codedom
/// </summary>
/// 
    class ClassGenerater : IClassGenerater
    {   // コンパイルユニット
        private CodeCompileUnit CompileUnit;
        // 生成したいクラス名
        private CodeTypeDeclaration TargetClass;
        // 生成するクラスファイル名 Const

        /// <summary>
        /// コンストラクタでオブジェクトの初期化をする。
        /// </summary>
        /// <param name="_nameSpaceName">名前空間名</param>
        /// <param name="_fileName">ファイル生成するときの名前</param>
        /// <param name="_className">クラス名</param>
        public ClassGenerater(string _nameSpaceName, string _fileName,string _className)
        {
            // コンパイルユニットのインスタンス生成
            CompileUnit  = new CodeCompileUnit();
            // 名前空間の設定
            CodeNamespace codeNamespace = new CodeNamespace(_nameSpaceName);
            // usingディレクティブを追加
            codeNamespace.Imports.Add(new CodeNamespaceImport("System"));
            // クラス名の設定
            TargetClass = new CodeTypeDeclaration(_className);
            // 参照型のクラスに設定
            TargetClass.IsClass = true;
            // クラスの設定
            // アクセス修飾子などなど
            TargetClass.TypeAttributes = System.Reflection.TypeAttributes.Public | System.Reflection.TypeAttributes.Sealed;
            // 作成した名前空間にクラスを設定する。
            codeNamespace.Types.Add(TargetClass);
            // コンパイラに作成した名前空間を設定する。
            CompileUnit.Namespaces.Add(codeNamespace);
        }

        public void AddProperty()
        {
            
        }

        public string GeneraterCodeFile()
        {
            return null;
        }
    }
}
