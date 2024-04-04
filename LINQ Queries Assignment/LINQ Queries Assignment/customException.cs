using System.Runtime.Serialization;

namespace LINQ_Queries_Assignment
{
    [Serializable]
    internal class customException : Exception
    {
        public customException()
        {
        }

        public customException(string? message) : base(message)
        {
        }


    }
}