using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ModdAnalyserForTVSBatch
{
    public class MoodAnalyserFactory
    {
        public object CreateMoodAnalyserObject(string className, string constructor)
        {
            //MoodAnalyserBatch009.MoodAnalyser
            string pattern = @"." + constructor + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(className);
                    var res = Activator.CreateInstance(moodAnalyserType);
                    return res;

                }
                catch (Exception ex)
                {
                    throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.CLASS_NOT_FOUND, "class not found");
                }
            }
            else
            {
                throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "constructor not found");
            }
        }

        /// <summary>
        /// UC 5 - creating parameterized constuctor
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructor"></param>
        /// <returns></returns>
        public object CreateMoodAnalyserParameterizedObject(string className, string constructor, string message)
        {
            try
            {
                Type type = typeof(MoodAnalyser);
                if (type.Name.Equals(className) || type.FullName.Equals(className))
                {
                    if (type.Name.Equals(constructor))
                    {
                        ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                        var obj = constructorInfo.Invoke(new object[] { message });
                        return obj;
                    }
                    else
                        throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "constructor not found");
                }
                else
                {
                    throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.CLASS_NOT_FOUND, "class not found");
                }

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public string InvokeAnalyserMethod(string message, string methodName)
        {
            try
            {
                Type type = typeof(MoodAnalyser);               
                MethodInfo methodInfo = type.GetMethod(methodName);
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                object moodAnalyserObject = factory.CreateMoodAnalyserParameterizedObject("ModdAnalyserForTVSBatch.MoodAnalyser", "MoodAnalyser", message);
                object info = methodInfo.Invoke(moodAnalyserObject, null);
                return info.ToString();
            }
            catch (NullReferenceException)
            {
                throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "method not found");
            }
        }

        public string SetField(string msg, string fieldName)
        {
            try
            {
                MoodAnalyserFactory fac = new MoodAnalyserFactory();
                MoodAnalyser obj = (MoodAnalyser)fac.CreateMoodAnalyserObject("ModdAnalyserForTVSBatch.MoodAnalyser", "MoodAnalyser");
                Type type = typeof(MoodAnalyser);
                FieldInfo field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.Instance);
                if (field != null)
                {
                    if (msg == null)
                    {
                        throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NULL_MESSAGE, "Message should not be null");
                    }
                    field.SetValue(obj, msg);
                    return obj.message;
                }
                throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.FIELD_NULL, "FieldName should not be null");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
