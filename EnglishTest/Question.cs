using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EnglishTest
{
    /// <summary>
    /// 問題マスタークラス
    /// </summary>
    class QuestionMaster
    {
        [DataMember]
        private List<AbstractQuestion> AllQuestionList;

        private string XML_DIR = Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName;
        private string XML_FILE_NAME = "Questions.xml";
        private string LOG_DIR = Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName;
        private string LOG_FILE_NAME = "EnglishTest.log";

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public QuestionMaster()
        {

        }

        /// <summary>
        /// 全問題取得
        /// </summary>
        /// <returns></returns>
        private bool GetAllQuestions()
        {
            return true;
        }

        /// <summary>
        /// デシリアライズ処理
        /// </summary>
        /// <returns></returns>
        private bool Deserialize()
        {
            // シリアライザオブジェクト作成
            DataContractSerializer serializer = new DataContractSerializer(typeof(List<AbstractQuestion>));

            try
            {
                // XMLWriter作成
                XmlReader reader = XmlReader.Create(XML_DIR + XML_FILE_NAME);

                // 出力
                AllQuestionList = (List<AbstractQuestion>)serializer.ReadObject(reader);

                string test = "testes";

                return true;
            }
            catch (Exception e)
            {

                return false;
            }

        }

        /// <summary>
        /// シリアライズ処理
        /// </summary>
        /// <returns></returns>
        private bool Serialize()
        {
            // シリアライザオブジェクト作成
            DataContractSerializer serializer = new DataContractSerializer(typeof(List<AbstractQuestion>));

            // 文字コードUTF-8(BOM無し)指定
            XmlWriterSettings setting = new XmlWriterSettings();
            setting.Encoding = new System.Text.UTF8Encoding(false);

            try
            {
                // XMLWriter作成
                XmlWriter writer = XmlWriter.Create(XML_DIR + XML_FILE_NAME, setting);

                // 出力
                serializer.WriteObject(writer, AllQuestionList);

                return true;
            }
            catch (Exception e)
            {

                return false;
            }

        }

    }
    /// <summary>
    /// 問題抽象クラス
    /// </summary>
    [DataContract]
    abstract class AbstractQuestion
    {
        [DataMember]
        public string QuestionText;

        [DataMember]
        public AbstractAnswer Answer;

        [DataMember]
        public int Score;

        [DataMember]
        public int TimeLimit;

        public abstract void CreateForm();

        public abstract void ShowQuestion();

    }

    [DataContract]
    class TextQuestion
    {

        /// <summary>
        /// フォーム作成
        /// </summary>
        public void CreateForm()
        {

        }
    }

    /// <summary>
    /// 答えの抽象クラス
    /// </summary>
    public abstract class AbstractAnswer
    {
    }

    /// <summary>
    /// 品詞回答クラス
    /// </summary>
    public class WordClassAnswer
    {
        public WordClass value;
    }

    /// <summary>
    /// 数値回答クラス
    /// </summary>
    public class IntegerAnswer
    {
        public int value;
    }

    /// <summary>
    /// 文字列回答クラス
    /// </summary>
    public class StringAnswer
    {
        public string value;
    }

    /// <summary>
    /// 品詞の列挙値
    /// </summary>
    public enum WordClass
    {
           名詞,
           代名詞,
           動詞,
           助動詞,
           形容詞,
           副詞,
           前置詞,
           接続詞,
           間投詞
    }
}
