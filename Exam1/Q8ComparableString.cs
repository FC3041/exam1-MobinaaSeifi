using System.Data.Common;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

namespace Exam1;

// public class Q8StringLengthComparer : IComparer<string>
// {
    // public Q8StringLengthComparer(){}
    // public int Compare(string? x, string? y)
    // {
    //      int z = 0;
    //     if(x is null && y is not null)
    //         return -1;
    //     else if (y is null && x is not null)
    //         return 1;
    //     else if(y is null && x is null)
    //         return 0;
    //     else if(x.Length>y.Length)
    //         return 1;
    //     else if(x.Length < y.Length)
    //         return -1;
    //     else if(x.Length == y.Length)
    //         {
               
    //             for(int i=0; i<x.Length; i++)
    //             {
    //                 if(x[i]<y[i])
    //                     return -1;
            
    //                 else if (x[i] > y[i])
    //                     return 1;
    //                 else 
    //                     z++;
                    
    //             }
                
                
    //         }
    //         else if(z == x.Length )
    //             return 0;
    //         else return -1;
    // }
// }
public class Q8ComparableString
    {
        public string? first { get; set;}
        public Q8ComparableString(string? ab)
        {
            this.first = ab;
        }
        public static bool operator<(Q8ComparableString? a, Q8ComparableString? b)
        {
            if(a.first is null && b.first is not null)
                return true;
            else if(b.first is null && a.first is not null)
                return false;
            
            else if(a.first.Length < b.first.Length)
                return true;
            else if(a.first.Length == b.first.Length)
            {
                if(a.first[0] < b.first[0])
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator>(Q8ComparableString a, Q8ComparableString b)
        {
            if(a.first is null && b.first is not null)
                return false;
            else if(b.first is null && a.first is not null)
                return true;
            else if(a.first.Length > b.first.Length)
                return true;
            else if(a.first.Length == b.first.Length)
            {
                if(a.first[0] > b.first[0])
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

    public override bool Equals(object obj)
    {
        // 
        if(obj is not Q8ComparableString other)
            return false;
        return this.first == other.first;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(first);
    }
    public static bool operator==(Q8ComparableString a, Q8ComparableString b)
    {
        if(Equals(a,b)) 
            return true;
        if(a is null || b is null)
            return false;
        return a.Equals(b);
    }
    public static bool operator!=(Q8ComparableString a, Q8ComparableString b)
    {
        return !(a==b);
    }


    }

