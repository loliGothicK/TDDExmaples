using System;
using System.Linq.Expressions;

namespace Cranberries.Util
{

    static partial class Make
    {
        public static Expression<Func<TR>> Expression<TR>(Expression<Func<TR>> e)
        {
            return e;
        }

        public static Expression<Func<T1, TR>> Expression<T1, TR>(Expression<Func<T1, TR>> e)
        {
            return e;
        }

        public static Expression<Func<T1, T2, TR>> Expression<T1, T2, TR>(Expression<Func<T1, T2, TR>> e)
        {
            return e;
        }

        public static Expression<Func<T1, T2, T3, TR>> Expression<T1, T2, T3, TR>(Expression<Func<T1, T2, T3, TR>> e)
        {
            return e;
        }

        public static Expression<Func<T1, T2, T3, T4, TR>> Expression<T1, T2, T3, T4, TR>(Expression<Func<T1, T2, T3, T4, TR>> e)
        {
            return e;
        }
    }
    /// <summary>
    /// 演算子の参照を取得するクラス
    /// 同じ型同士の演算
    /// </summary>
    /// <typeparam name="T">演算する型</typeparam>
    public static class Operator<T>
    {
        /// <summary>
        /// 加算
        /// </summary>
        public static readonly Func<T, T, T> Add = GetLambda(Expression.Add);
        /// <summary>
        /// 減算
        /// </summary>
        public static readonly Func<T, T, T> Subtract = GetLambda(Expression.Subtract);
        /// <summary>
        /// 積算
        /// </summary>
        public static readonly Func<T, T, T> Multiply = GetLambda(Expression.Multiply);
        /// <summary>
        /// 除算
        /// </summary>
        public static readonly Func<T, T, T> Divide = GetLambda(Expression.Divide);
        /// <summary>
        /// インクリメント
        /// </summary>
        public static readonly Func<T, T> Increment = GetLambda(Expression.Increment);
        /// <summary>
        /// デクリメント
        /// </summary>
        public static readonly Func<T, T> Decrement = GetLambda(Expression.Decrement);

        /// <summary>
        /// 入力1、出力1の演算子ラムダ式を取得する
        /// </summary>
        /// <param name="ex">演算子のExpression</param>
        /// <returns>ラムダ式</returns>
        private static Func<T, T> GetLambda(Func<ParameterExpression, UnaryExpression> ex)
        {
            var x = Expression.Parameter(type: typeof(T)); // 引数 x の式
            return Expression.Lambda<Func<T, T>>
                (ex(x), x)
                .Compile();
        }

        /// <summary>
        /// 入力2、出力1の演算子ラムダ式を取得する
        /// </summary>
        /// <param name="ex">演算子のExpression</param>
        /// <returns>ラムダ式</returns>
        private static Func<T, T, T> GetLambda(Func<ParameterExpression, ParameterExpression, BinaryExpression> ex)
        {
            var x = Expression.Parameter(type: typeof(T));
            var y = Expression.Parameter(type: typeof(T));
            return Expression.Lambda<Func<T, T, T>>
                (ex(x, y), x, y)
                .Compile();
        }
    }
}