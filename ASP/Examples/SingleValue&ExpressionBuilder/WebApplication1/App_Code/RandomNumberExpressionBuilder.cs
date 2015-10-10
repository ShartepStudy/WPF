using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using System.CodeDom;
using System.Web.UI;

public class RandomNumberExpressionBuilder : ExpressionBuilder
{
    public override CodeExpression GetCodeExpression(BoundPropertyEntry entry,
        object parsedData, ExpressionBuilderContext context)
    {
        // entry.Expression - строка с числом 
        // без префикса (например: "1,6").
        if (!entry.Expression.Contains(","))
        {
            throw new ArgumentException(" Должны быть указаны два числа, разделенные запятой");
        }
        else
        {
            // Получить два числа
            string[] numbers = entry.Expression.Split(',');

            if (numbers.Length != 2)
            {
                throw new ArgumentException("Должны быть указаны два числа");
            }
            else
            {
                int min, max;
                if (Int32.TryParse(numbers[0], out min) &&
                    Int32.TryParse(numbers[1], out max))
                {

                    // Получить ссылку на класс, имеющий метод GetRandomNumber(). 
                    // (Это класс, где данный код выполняется.)
                    CodeTypeReferenceExpression typeRef = new CodeTypeReferenceExpression(this.GetType());

                    // Определить параметры для GetRandomNumber().
                    CodeExpression[] methodParameters = new CodeExpression[2];
                    methodParameters[0] = new CodePrimitiveExpression(min);
                    methodParameters[1] = new CodePrimitiveExpression(max);

                    // Вернуть выражение привязки вызвав метод GetRandomNumber()
                    CodeMethodInvokeExpression methodCall = new CodeMethodInvokeExpression(
                        typeRef, "GetRandomNumber", methodParameters);
                    return methodCall;
                }
                else
                {
                    throw new ArgumentException("Должны использоваться допустимые целые числа");
                }

            }
        }
    }

    // Генератор случайных чисел
    public static string GetRandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max).ToString();
    }
}