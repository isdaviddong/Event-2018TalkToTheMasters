using isRock.Framework;
using isRock.Framework.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testWebSite.BO
{
    #region "這是樣板，實際BusinessLogic不該寫在Controller這裡，請移到獨立的Class"
    //回傳參數(也可以視為ViewModel)
    public class TestMethodResut
    {
        public int value1 { get; set; }
        public string value2 { get; set; }
    }
    //傳入參數
    public class TestMethodParameter
    {
        public int ValueA { get; set; }
        public string ValueB { get; set; }
    }
    //必須繼承 BusinessLogicBase
    public class TestClassA : BusinessLogicBase
    {
        //請注意，務必只能有一個傳入參數
        public ExecuteCommandDefaultResult TestMethodA(TestMethodParameter para)
        {
            return new ExecuteCommandDefaultResult
            {
                Data = new TestMethodResut() { value1 = para.ValueA, value2 = para.ValueB },
                isSuccess = true,
                Message = ""
            };
        }
    }
    #endregion
}