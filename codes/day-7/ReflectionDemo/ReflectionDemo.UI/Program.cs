using System; //Type, Activator
using System.Reflection; //Assembly, MethodInfo,  ParameterInfo, PropertyInfo, FieldInfo, etc...

namespace ReflectionDemo.UI
{
    class Program
    {

        static void Main()
        {            
            // dynamically:
            // load an application (generally a library)
            //@ --> string verbatim:use it to tell compiler to ignore escape sequences (like \n, \t, etc.)
            Assembly loadedAssembly = Assembly.LoadFile(@"E:\siemens_ta_22ndMarch2021\codes\day-7\ReflectionDemo\ReflectionDemo.Entities\bin\Debug\ReflectionDemo.Entities.dll");
            Console.WriteLine($"Assembly Info: \n {loadedAssembly.FullName}");

            // create object of calculation class
            //a. extract calculation class information:
            //Type t = typeof(Calculation);

            //metadata of the class from the Assembly
            Type calculationType = loadedAssembly.GetType("ReflectionDemo.Entities.Calculation");


            //Activator class helps you to create instance of any class DYNAMICALLY from the supplied type information (metadata)
            object calculationRef = Activator.CreateInstance(calculationType);

            // call methods for calculation using metadata of the methods
            //MethodInfo class is used to store information about any method

            MethodInfo addMethodInfo = calculationType.GetMethod("Add");
            Console.WriteLine($"\nName: {addMethodInfo.Name}");
            Console.WriteLine($"Return Type: {addMethodInfo.ReturnType}");
            Console.WriteLine($"Abstract? {addMethodInfo.IsAbstract}");
            Console.WriteLine($"Static? {addMethodInfo.IsStatic}");

            ParameterInfo[] allParameters = addMethodInfo.GetParameters();
            foreach (ParameterInfo info in allParameters)
            {
                Console.WriteLine($"\nName:{info.Name}");
                Console.WriteLine($"Data Type:{info.ParameterType}");
                Console.WriteLine($"Position:{info.Position}");
            }

            object[] parameters = new object[] { 12, 13 };
            addMethodInfo.Invoke(calculationRef, parameters);

            // call properties to display results using metadata of properties
            PropertyInfo addResultPropInfo = calculationType.GetProperty("AddResult");
            object addResult = addResultPropInfo.GetValue(calculationRef);
            Console.WriteLine($"\nResult of Addition:{addResult}");

            MethodInfo multiMethodInfo = calculationType.GetMethod("Multiply");
            ParameterInfo[] multiParameters = multiMethodInfo.GetParameters();
            object[] parametersMulti = new object[] { 12, 4 };
            multiMethodInfo.Invoke(calculationRef, parametersMulti);

            PropertyInfo multiResultPropInfo = calculationType.GetProperty("MultiResult");
            object multiResult = multiResultPropInfo.GetValue(calculationRef);
            Console.WriteLine($"\nResult of multiplication: {multiResult}");

            MethodInfo subMethodInfo = calculationType.GetMethod("Subtract");
            ParameterInfo[] subParameterInfo = subMethodInfo.GetParameters();
            object[] subParameters = new object[] { 12, 3 };

            object subResult = null;
            if (subMethodInfo.IsStatic)
            {
                subResult = subMethodInfo.Invoke(null, subParameters);
            }
            else
            {
                subResult = subMethodInfo.Invoke(calculationRef, subParameters);
            }
            Console.WriteLine($"\nResult of Subtraction: {subResult}");

            Type[] all = loadedAssembly.GetTypes();
            foreach (Type type in all)
            {
                // MethodInfo[] allMethods = type.GetCustomAttribute(typeof(TestMethod));

            }
        }
    }
}
