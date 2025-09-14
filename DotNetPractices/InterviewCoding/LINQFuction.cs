namespace InterviewCoding
{
    public class LINQFuction
    {
        public int GetUniqueMemberIds(List<Member> members)
        {
            int a = 0;
            try
            {
                a = 1;
                throw new Exception();
            }
            catch (Exception)
            {
                a = 2;
            }
            finally
            {
                //a = 3;
            }
            Console.WriteLine(a);

            return a;
            //return members.Select(s => s.ID).Distinct().ToList();
        }

    }

    public class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
}
