using System;

namespace BasicCalendar
{
    class Program
    {
        private static Vco_DrawCalender Drawer_Calendar;

        static void Main(string[] args)
        {
            /**
             * このコードは、カレンダー表示プログラムのテストのために用意しています。
             * 曜日の表示形式、西暦年、月の入力は正しいものが入力されることを前提としています。
             * 
             * 想定外の数値が入力され、問題が起きても無視してください。
             */

            // 入力された数値を保持する変数の宣言
            string _inputMode;
            string _inputYear;
            string _inputMonth;

            // 説明表示
            Console.WriteLine("Calendarを表示します");
            Console.WriteLine("以下は半角数字で入力してください");
            Console.WriteLine("曜日の表示形式を選択してください");
            Console.WriteLine("0 : 月");
            Console.WriteLine("1 : 月曜日");
            Console.WriteLine("2 : Mon");

            // コンソールから入力された曜日の表示形式を、変数に代入
            _inputMode = Console.ReadLine();

            // 入力された数値の確認
            Console.WriteLine("選択した表示形式");

            switch (_inputMode)
            {
                case "0":
                    Console.WriteLine("0 : 月");
                    break;

                case "1":
                    Console.WriteLine("1 : 月曜日");
                    break;

                case "2":
                    Console.WriteLine("2 : Mon");
                    break;
            }



            // 説明表示
            Console.WriteLine("\n表示する年を西暦で入力してください");

            // コンソールから入力された西暦を、変数に代入
            _inputYear = Console.ReadLine();

            // 入力された西暦の確認
            Console.WriteLine("入力した西暦 : {0}", _inputYear);



            // 説明表示
            Console.WriteLine("\n表示する月を入力してください");

            // コンソールから入力された月を、変数に代入
            _inputMonth = Console.ReadLine();

            // コンソールから入力された月を、変数に代入
            Console.WriteLine("入力した月 : {0}\n", _inputMonth);

            // 入力された各種数値を、string 型から int 型にキャスト
            int _drawMode = Convert.ToInt32(_inputMode);
            int _drawYear = Convert.ToInt32(_inputYear);
            int _drawMonth = Convert.ToInt32(_inputMonth);

            Drawer_Calendar = new Vco_DrawCalender(_drawMode, _drawYear, _drawMonth);

            // 以下の行は、このコードの最終行に来るようにして、決して消さないでください
            Console.ReadLine();
        }
    }
}
