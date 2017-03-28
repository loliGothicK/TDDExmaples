using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace UnitTestProject1
{
    [TestClass]
    public class FakeTest
    {
        public class 学生
        {
            int 学生番号_;
            String 姓_;
            String 名_;

            public int 学生番号 { get => 学生番号_; set => 学生番号_ = value; }
            public string 姓 { get => 姓_; set => 姓_ = value; }
            public string 名 { get => 名_; set => 名_ = value; }

        }

        public class 学生名簿 : IEnumerable<学生>
        {
            public List<学生> list { get; set; }

            public void Add(学生 a) => list.Add(a);

            public 学生名簿(params 学生[] input)
            {
                list = input.ToList();
            }

            public IEnumerator<学生> GetEnumerator()
            {
                foreach ( var e in list)
                {
                    yield return e;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }
        public static IEnumerable<String> GetOddNumbers(学生名簿 db)
        {
            return from p in db
                   where p.学生番号 % 2 == 1
                   orderby p.学生番号
                   select p.名;
        }

        [TestMethod]
        public void FakeTestMethod()
        {
            var 名簿 = new 学生名簿 {
                new 学生 { 学生番号 = 12, 姓 = "乙坂", 名 = "有宇"  },
                new 学生 { 学生番号 = 15, 姓 = "友利", 名 = "奈緒"  },
                new 学生 { 学生番号 = 16, 姓 = "高城", 名 = "丈士朗"},
                new 学生 { 学生番号 = 14, 姓 = "西森", 名 = "柚咲"  },
                new 学生 { 学生番号 = 25, 姓 = "乙坂", 名 = "歩未"  }
             };

            CollectionAssert.AreEquivalent(
                new List<String> { "奈緒", "歩未" },
                GetOddNumbers(名簿).ToList()
                );
        }
    }
}
