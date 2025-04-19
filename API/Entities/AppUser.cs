using Microsoft.VisualBasic;
using System.Reflection;
using System.Security.Cryptography.Xml;

namespace API.Entities
{
    public class AppUser
    {
        private int _id;

        //Primitive type. It has a default value as 0
        //When a value type is passed as a parameter, the runtime creates a copy of the value on the stack and passes that value into a method. This is why integers must be passed with a 'ref' keyword to return an updated value.
        public int Id 
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            } 
        }
        //It has a default value as null instead of empty

        //Strings are passed as reference types in .NET.

        //Reference types place a pointer on the stack, to the actual instance that resides on the managed heap.This is different to Value types, who hold their entire instance on the stack.
        //When a reference type is passed, the runtime creates a copy of the pointer on the stack. That copied pointer still points to the original instance of the reference type.
        //Immutable=> Once str1 is copied to str2, str2 maintains seperate pointer.
        // Str2 no longer mutate str1. Str1 has it's own data.
        public required string UserName
        {
            get;
            set;
        }
    }
}
