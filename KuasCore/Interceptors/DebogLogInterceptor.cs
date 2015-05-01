using AopAlliance.Intercept;
using System;
using System.Diagnostics;

namespace KuasCore.Interceptors 
{
    class DebogLogInterceptor : IMethodInterceptor
    {

        public object Invoke(IMethodInvocation invocation)
        {


            object result = invocation.Proceed();



            return result;
        }
    }
}
