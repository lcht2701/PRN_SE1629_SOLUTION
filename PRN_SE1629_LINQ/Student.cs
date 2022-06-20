namespace PRN_SE1629;
internal class Student
{
    public int Id { get; set; }
    public double Score { get; set; }

    public Student(int id, double score)
    {
        Id = id;
        Score = score;
    }

    public override string? ToString()
    {
        return $"ID = {Id}, Mark = {Score}";
    }

}
