using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wasalee.Utility
{
    public static class Global
    {
        public class ResponseMessages
        {
            public const string Success = "Success";
            public const string NotFound = "NotFound";
            public const string BadRequest = "BadRequest";
            public const string Conflict = "Conflict";
            public const string Forbidden = "Forbidden";

            public static string CannotBeEmpty(params string[] args)
            {
                try
                {
                    string returnString = "";
                    for (int i = 0; i < args.Length; i++)
                        returnString += args[i] + ", ";
                    returnString = returnString.Remove(returnString.LastIndexOf(','), 1);
                    return returnString + "cannot be empty";
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static string GenerateInvalid(params string[] args)
            {
                try
                {
                    string returnString = "";
                    for (int i = 0; i < args.Length; i++)
                        returnString += args[i] + ", ";
                    returnString = returnString.Remove(returnString.LastIndexOf(','), 1);
                    return "Invalid " + returnString;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static string GenerateAlreadyExists(string arg)
            {
                try
                {
                    return arg + " already exists";
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static string GenerateNotFound(string arg)
            {
                try
                {
                    return arg + " not found";
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }

}
