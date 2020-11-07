
namespace MOQPractice
{
    public class Process
    {

        public bool AddProcess(SubProcess subProcess)
        {
            subProcess.ProcessNew();

            int result = subProcess.AnotherProcess(); //this method default error  and ignore by using moq .Return default result in test case. 
            //main goal moq is if any task have several step ,we can test each of them using it .

            return true;
        }
    }
}
