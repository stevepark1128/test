using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace leetcode
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
    public partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //LengthOfLongestSubstring("pwwkew");
            
            //?LongestPalindrome("cwziydanrqvsdtvnnqgjnbrvvwxwqojeqgxhwxdoktjktulemwpbeqscbbtbfvkxsrjetfdrovcrdwzfmnnihtgxybuairswfewvpuscocqifuwylhssldpjrawqdrbvkykpaggspbfrulcktpbofchzikhzxhpocgvdbwpewpywsgqbczmamprklaoovcfecwchhmsaqkhvuvvzjblmgvqpqtnlipgqsanvovylpmxlmxvymppdykphhaamtxjnnlsqfwjwhyywgurteaummwhvavxbcpgrfffxrowluqmqjaugryxdmwvyokdcfcvcytxpixbvwrdgzctejdoaavgtezexmvxgrkpnayvfarkyoruofqmpnsqdzojxqrjsnfwsbzjmaoigytygukqlrcqaxazvmytgfghdczvzphfdbnxtklaiqqsotavdmhiaermluafheowcobjqmrkmlzyas");
            //LongestPalindrome("abacabz");
            //LongestPalindrome("ibvjkmpyzsifuxcabqqpahjdeuzaybqsrsmbfplxycsafogotliyvhxjtkrbzqxlyfwujzhkdafhebvsdhkkdbhlhmaoxmbkqiwiusngkbdhlvxdyvnjrzvxmukvdfobzlmvnbnilnsyrgoygfdzjlymhprcpxsnxpcafctikxxybcusgjwmfklkffehbvlhvxfiddznwumxosomfbgxoruoqrhezgsgidgcfzbtdftjxeahriirqgxbhicoxavquhbkaomrroghdnfkknyigsluqebaqrtcwgmlnvmxoagisdmsokeznjsnwpxygjjptvyjjkbmkxvlivinmpnpxgmmorkasebngirckqcawgevljplkkgextudqaodwqmfljljhrujoerycoojwwgtklypicgkyaboqjfivbeqdlonxeidgxsyzugkntoevwfuxovazcyayvwbcqswzhytlmtmrtwpikgacnpkbwgfmpavzyjoxughwhvlsxsgttbcyrlkaarngeoaldsdtjncivhcfsaohmdhgbwkuemcembmlwbwquxfaiukoqvzmgoeppieztdacvwngbkcxknbytvztodbfnjhbtwpjlzuajnlzfmmujhcggpdcwdquutdiubgcvnxvgspmfumeqrofewynizvynavjzkbpkuxxvkjujectdyfwygnfsukvzflcuxxzvxzravzznpxttduajhbsyiywpqunnarabcroljwcbdydagachbobkcvudkoddldaucwruobfylfhyvjuynjrosxczgjwudpxaqwnboxgxybnngxxhibesiaxkicinikzzmonftqkcudlzfzutplbycejmkpxcygsafzkgudy");
            
            //Reverse(-123);
            
            //IsPalindrome(123);
            
            //Convert("PAYPALISHIRING", 3);
            //Convert("PAYPALISHIRING", 4);
            
            //int[] height = {1,8,6,2,5,4,8,3,7};
            //?MaxArea(height);

            //IntToRoman(1994);

            //string[] strs = {"flower","flow","flight"};
            //LongestCommonPrefix(strs);

            // int[] ts = {-1,0,1,2,-1,-4};
            // int[] ts2 = {-2,0,1,1,2};
            // int[] ts3 = {-4,-2,-2,-2,0,1,2,2,2,3,3,4,4,6,6};
            // ThreeSum(ts3);

            // int[] ts = {-1,2,1,-4};
            // int[] ts2 = {-3,-2,-5,3,-4};
            // int[] ts3 = {-16,-2,17,-16,3,-7,-13,20,-4,12,5,13,-7,0,5,4,-17,-16,9,1,8,-6,0,-8,16,10,-6,9,-4,12,16,5,19,2,-9,-17,-8,-17,7,-10,2,20,-18,-20,-14,-6,6,17,-10,-8,18,-15,7,-9,13,13,-13,3,18,10,12,16,-6,-19,-6,-13,8,-5,16,5,8,-3,-9,-9,-5,14,14,-13,-18,13,15,-3,9,14,18,-14,-14,1,20,-4,-6,0,3,15,20,20,9,13,-8,-1,-2,6};
            // ThreeSumClosest(ts3, -58);

            //LetterCombinations("234");
            // Console.Write(IsValid("{{()}}{()}()[]"));
            //Console.Write(IsValid("({()})"));
            //Console.Write(IsValid("(([]){})"));

            // ListNode l1 = new ListNode(
            //     1,
            //     new ListNode(
            //         2,
            //         new ListNode(
            //             4,
            //             null
            //         )
            //     )
            // ); 
            // ListNode l2 = new ListNode(
            //     1,
            //     new ListNode(
            //         3,
            //         new ListNode(
            //             4,
            //             null
            //         )
            //     )
            // ); 
            // MergeTwoLists(l1, l2);

            // ListNode l2 = new ListNode(
            //     1,
            //     new ListNode(
            //         2,
            //         new ListNode(
            //             3,
            //             new ListNode(
            //             4,
            //             null
            //         )
            //         )
            //     )
            //  ); 
             //displayListNode(l2);
             //displayListNode(SwapPairs(l2));
             
             //int[] ts = {1,1,2};
             //RemoveDuplicates(ref ts);
             //displayInyArr(ts);

             //Console.WriteLine(Divide(-2147483648, 2));

            //string[] st = {"bar","foo","the"};
            //display2(FindSubstring("barfoofoobarthefoobarman", st));
            //string[] st = {"a","a"};
            //display2(FindSubstring("aaa", st));

            //string[] st = {"dhvf","sind","ffsl","yekr","zwzq","kpeo","cila","tfty","modg","ztjg","ybty","heqg","cpwo","gdcj","lnle","sefg","vimw","bxcb"};
            //display2(FindSubstring("pjzkrkevzztxductzzxmxsvwjkxpvukmfjywwetvfnujhweiybwvvsrfequzkhossmootkmyxgjgfordrpapjuunmqnxxdrqrfgkrsjqbszgiqlcfnrpjlcwdrvbumtotzylshdvccdmsqoadfrpsvnwpizlwszrtyclhgilklydbmfhuywotjmktnwrfvizvnmfvvqfiokkdprznnnjycttprkxpuykhmpchiksyucbmtabiqkisgbhxngmhezrrqvayfsxauampdpxtafniiwfvdufhtwajrbkxtjzqjnfocdhekumttuqwovfjrgulhekcpjszyynadxhnttgmnxkduqmmyhzfnjhducesctufqbumxbamalqudeibljgbspeotkgvddcwgxidaiqcvgwykhbysjzlzfbupkqunuqtraxrlptivshhbihtsigtpipguhbhctcvubnhqipncyxfjebdnjyetnlnvmuxhzsdahkrscewabejifmxombiamxvauuitoltyymsarqcuuoezcbqpdaprxmsrickwpgwpsoplhugbikbkotzrtqkscekkgwjycfnvwfgdzogjzjvpcvixnsqsxacfwndzvrwrycwxrcismdhqapoojegggkocyrdtkzmiekhxoppctytvphjynrhtcvxcobxbcjjivtfjiwmduhzjokkbctweqtigwfhzorjlkpuuliaipbtfldinyetoybvugevwvhhhweejogrghllsouipabfafcxnhukcbtmxzshoyyufjhzadhrelweszbfgwpkzlwxkogyogutscvuhcllphshivnoteztpxsaoaacgxyaztuixhunrowzljqfqrahosheukhahhbiaxqzfmmwcjxountkevsvpbzjnilwpoermxrtlfroqoclexxisrdhvfsindffslyekrzwzqkpeocilatftymodgztjgybtyheqgcpwogdcjlnlesefg", st));
        
            //int[] nums = {1,2,3};
            //NextPermutation(nums);

            //LongestValidParentheses("(()");
            //char[][] board = new char[9][];
            // board[0] = new char[] {'5','3','.','.','7','.','.','.','.'};
            // board[1]= new char[] {'6','.','.','1','9','5','.','.','.'};
            // board[2]= new char[] {'.','9','8','.','.','.','.','6','.'};
            // board[3]= new char[] {'8','.','.','.','6','.','.','.','3'};
            // board[4]= new char[] {'4','.','.','8','.','3','.','.','1'};
            // board[5]= new char[] {'7','.','.','.','2','.','.','.','6'};
            // board[6]= new char[] {'.','6','.','.','.','.','2','8','.'};
            // board[7]= new char[] {'.','.','.','4','1','9','.','.','5'};
            // board[8]= new char[] {'.','.','.','.','8','.','.','7','9'};

            // board[0]= new char[] {'.','.','.','.','5','.','.','1','.'};
            // board[1]= new char[] {'.','4','.','3','.','.','.','.','.'};
            // board[2]= new char[] {'.','.','.','.','.','3','.','.','1'};
            // board[3]= new char[] {'8','.','.','.','.','.','.','2','.'};
            // board[4]= new char[] {'.','.','2','.','7','.','.','.','.'};
            // board[5]= new char[] {'.','1','5','.','.','.','.','.','.'};
            // board[6]= new char[] {'.','.','.','.','.','2','.','.','.'};
            // board[7]= new char[] {'.','2','.','9','.','.','.','.','.'};
            // board[8]= new char[] {'.','.','4','.','.','.','.','.','.'};
            // Console.WriteLine(IsValidSudoku(board));

            //CountAndSay(4);

            //int[] nums = {2,3,6,7};
            //CombinationSum(nums, 7);

            //int[] nums = {0,1,0,2,1,0,1,3,2,1,2,1};
            //int[] nums = {4,2,3};
            //Console.WriteLine("==" + Trap(nums));

            //Console.WriteLine(IsMatch("abefcdgiescdfimde", "ab*cd?i*de"));
            //Console.WriteLine(IsMatch("acdcb","a*c?b"));
            //Console.WriteLine(IsMatch("mississippi","m??*ss*?i*pi"));
            //Console.WriteLine(IsMatch("adceb","*a*b"));
            //Console.WriteLine(IsMatch("aaaa","***a"));
            //Console.WriteLine(IsMatch("a","a*"));
            //Console.WriteLine(IsMatch("leetcode","*e*t?d*"));
            //Console.WriteLine(IsMatch("b","??"));
            //Console.WriteLine(IsMatch("bcd","*?*"));
            //Console.WriteLine(IsMatch("ho","**ho"));
            //Console.WriteLine(IsMatch("babaaababaabababbbbbbaabaabbabababbaababbaaabbbaaab","***bba**a*bbba**aab**b"));

            //Console.WriteLine(Multiply("19000000000000000000000000000000000000000", "19"));
            //Console.WriteLine(Multiply("123", "456"));
            //Console.WriteLine(Multiply("123456789","987654321"));
            //Console.WriteLine(Multiply("3","514"));
            //Console.WriteLine(Multiply("2925","4787"));
            //Console.WriteLine(Multiply("103","98"));
            //Console.WriteLine(Multiply("14992561453667515041174576364495007455793","71852359466035794333134891563860065492369184753318"));
            
            //int[] nums = {1,2,3};
            //displayIntListList(Permute(nums));
            // int[][] nums = new int[3][];
            // nums[0] = new int[] {1,2,3};
            // nums[1] = new int[] {4,5,6}; 
            // nums[2] = new int[] {7,8,9};  
            //input[[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
            //answ[[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]
            //current[[15,2,13,5],[14,4,8,1],[12,3,6,9],[16,10,7,11]]
            // int[][] nums = new int[4][];
            // nums[0] = new int[] {5,1,9,11};
            // nums[1] = new int[] {2,4,8,10}; 
            // nums[2] = new int[] {13,3,6,7};
            // nums[3] = new int[] {15,14,12,16};
            // Rotate(nums);

            //int[] nums = {-2,1,-3,4,-1,2,1,-5,4};
            //int[] nums = {1};
            //MaxSubArray(nums);

            //string[] sts = {"eat","tea","tan","ate","nat","bat"};
            //displayStrListList(GroupAnagrams(sts));

            // int[][] nums = new int[3][];
            // nums[0] = new int[] {1,2,3};
            // nums[1] = new int[] {4,5,6}; 
            // nums[2] = new int[] {7,8,9};  
            // int[][] nums = new int[3][];
            // nums[0] = new int[] {1,2,3,4};
            // nums[1] = new int[] {5,6,7,8}; 
            // nums[2] = new int[] {9,10,11,12};  
            // int[][] nums = new int[4][];
            // nums[0] = new int[] {1,2,3,4};
            // nums[1] = new int[] {5,6,7,8}; 
            // nums[2] = new int[] {9,10,11,12};
            // nums[3] = new int[] {13,14,15,16}; 
            // SpiralOrder(nums);
            
            //int[] nums = new int[] {2,3,1,1,4};
            //int[] nums = new int[] {3,2,1,0,4};
            //int[] nums = new int[] {1,2,3};
            //int[] nums = new int[] {2,5,0,0};
            //Console.WriteLine(CanJump(nums));

            // int[][] nums = new int[4][];
            // nums[0] = new int[] {1,3};
            // nums[1] = new int[] {2,6}; 
            // nums[2] = new int[] {8,10};
            // nums[3] = new int[] {15,18};
            // displayIntArrArr(Merge(nums));

            //Console.WriteLine(LengthOfLastWord("b   a   "));
            
            //Console.WriteLine(GetPermutation(9,273815));
            
            // ListNode l3 = new ListNode(
            //     1,
            //     new ListNode(
            //         2,
            //         new ListNode(
            //             3,
            //             null
            //         )
            //     )
            //  ); 
            // ListNode l2 = new ListNode(
            //     1,
            //     new ListNode(
            //         2,
            //         new ListNode(
            //             3,
            //             new ListNode(
            //             4,
            //             new ListNode(
            //                 5,
            //                 null
            //                 )
            //             )
            //         )
            //     )
            //  ); 
            //  ListNode l1 = new ListNode(
            //     1,
            //     null
            //  ); 
            //  displayListNode(RotateRight(l3, 20000000000));

            //Console.WriteLine(UniquePaths(7, 3));
            //Console.WriteLine(UniquePaths(3, 2));
            //Console.WriteLine(UniquePaths(23, 12));

            // int[][] nums = new int[3][];
            // nums[0] = new int[] {1,3,1};
            // nums[1] = new int[] {1,5,1}; 
            // nums[2] = new int[] {4,2,1};
            // Console.WriteLine(MinPathSum(nums));

            // int[][] nums = new int[3][];
            // nums[0] = new int[] {0,1,2,0};
            // nums[1] = new int[] {3,4,5,2}; 
            // nums[2] = new int[] {1,3,1,5};
            //nums[2] = new int[] {4,2,1};
            //SetZeroes(nums);

            // int[] nums = new int[] {2,0,2,1,1,0};
            // SortColors(nums);

            //displayIntListList(Combine(9, 8));
            // int[] nums = new int[] {2,4};
            // Console.WriteLine(PermMissingElem(nums));
            //Console.WriteLine(solution2("Wed", 2));

            //Console.WriteLine(solution3("00:01:07,400-234-090"));

            //int[] nums = new int[] {3,4,5,3,7};
            int[] nums = new int[] {1,3,2,1,2,1,4};
            Console.WriteLine(solution4(nums));
        }

        public static int solution4(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        var nonAltTrees = returnNonAlternativeTrees(A);
        if(nonAltTrees.Count== 3) return 3;
        if(nonAltTrees.Count> 3) return -1;
        return 0;
    }
    public static IList<int> returnNonAlternativeTrees(int[] A) {
      List<int> nonAltTrees = new List<int>();
      for(int i=2;i<A.Length;i++){
       if(A[i-2] - A[i-1] >= 0){
        if(A[i-1] - A[i] >= 0){
          if(!nonAltTrees.Contains(A[i-2])) nonAltTrees.Add(A[i-2]); 
          if(!nonAltTrees.Contains(A[i-1])) nonAltTrees.Add(A[i-1]);
          if(!nonAltTrees.Contains(A[i])) nonAltTrees.Add(A[i]);
        }
       }
       if(A[i-2] - A[i-1] <= 0){
        if(A[i-1] - A[i] <= 0){
          if(!nonAltTrees.Contains(A[i-2])) nonAltTrees.Add(A[i-2]); 
          if(!nonAltTrees.Contains(A[i-1])) nonAltTrees.Add(A[i-1]);
          if(!nonAltTrees.Contains(A[i])) nonAltTrees.Add(A[i]);
        }
       }
      }
      return nonAltTrees; 
    }

        public static int solution3(string S) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        var recordStr = Regex.Split(S,"\r\n|\r|\n");
        Dictionary<string, int> records = new Dictionary<string, int>();
        for(int i=0; i<recordStr.Length;i++){
            Console.WriteLine(recordStr[i]);
           var temp = recordStr[i].Split(',');
           var duration = calculateDuration(temp[0]);
           Console.WriteLine(temp[0]);
           Console.WriteLine(duration);
           if(records.ContainsKey(temp[1])){
              records[temp[1]] = duration + records[temp[1]];
           } else {
              records.Add(temp[1], duration);
           }
        }
        var maxKey = records.OrderByDescending(x=>x.Value).First().Key;
        records.Remove(maxKey);
        int totalBill = 0;
        foreach(var record in records){
            if(record.Value <=5) {
            totalBill = totalBill + record.Value  * 60 * 3;
          } else {
            totalBill = totalBill + record.Value  * 150;
          }
        }
    
        return totalBill ;
    }
    public static int calculateDuration(string s) {
        var units = s.Split(':');
        int hr = int.Parse(units[0]) * 60;
        int min = int.Parse(units[1]);
        int sec = int.Parse(units[2]) > 0 ? 1:0;
        return hr+min+sec;
    }

        public static string solution2(string S, int K) {
            var result = Regex.Split(S, "\r\n|\r|\n");
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        string[] weeks = new string[] {"Mon","Tue","Wed","Thu","Fri","Sat","Sun"};
        int totalWeeks = weeks.Length;
        int foundIndex = -1;
        for(int i=0;i<weeks.Length;i++){
          if(weeks[i] == S) {
             foundIndex = i;
             break;
          }
        }
        int resultIndex = ((foundIndex + totalWeeks) % K -1);
        return weeks[resultIndex];
    }
        public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        var list = A.ToList();
        int rt = list[list.Count-1];
        list.Sort();
        if(list.Count == 1 && list[0] > 1) return list[0] -1;
        if(list.Count == 1 && list[0] == 1) return list[0] + 1;
        if(list.Count == 1 && list[0] < 1) return 1;
        
        if(list[0] > 0 && list[list.Count-1] > 0) {
            rt = missingValueIndex(list);
            if(rt > -1 && list[0] > 1) return list[0] -1;
            if(rt > -1 && list[0] == 1) return rt;
            if(rt == -1 && list[0] > 1) return list[0] -1;
            if(rt == -1 && list[0] == 1) return list[list.Count-1] +1;
        }
        
        if(list[0] < 0 && list[list.Count-1] < 0) return 1;
        if(list[0] < 0 && list[list.Count-1] > 0) {
            var positiveMin = list.Where(x=> x > 0).Select(x=>x).ToList();
            if(positiveMin[0] > 1) return 1;
            if(positiveMin[0] >=1) {
                return solution(positiveMin.ToArray());
            }
        }
        return rt;
    }
    public int missingValueIndex(List<int> list){
        int missing = -1;
        for(int i=list[0];i<=list[list.Count-1];i++){
            var temp = list.Where(x => x == i).Select(x=>x).ToList();
            if(temp.Count == 0) {
                missing = i;
            }
        }
        return missing;
    }
    
    

    
    

    
    
    
    
    
    
    
    
    }
}
