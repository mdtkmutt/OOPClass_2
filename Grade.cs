public class Grade
{
    private int _score;
    private string _grade;

    public Grade(int score)
    {
        _score = score;
        _grade = ConvertScoreToGrade(score);
    }

    private string ConvertScoreToGrade(int score)
    {
        if (score > 100)
        {
            throw new Exception("Please input data 0 - 100");
        }
        else if (IsGradeA(score))
        {
            return "Grade A";
        }
        else if (IsGradeBPlus(score))
        {
            return "Grade B+";
        }
        else if (IsGradeB(score))
        {
            return "Grade B";
        }
        else if (IsGradeCPlus(score))
        {
            return "Grade C+";
        }
        else if (IsGradeC(score))
        {
            return "Grade C";
        }
        else if (IsGradeDPlus(score))
        {
            return "Grade D+";
        }
        else if (IsGradeD(score))
        {
            return "Grade D";
        }
        else if (IsGradeF(score))
        {
            return "Grade F";
        }
        else
        {
            throw new Exception("Please input data 0 - 100");
        }
    }

    private bool IsGradeA(int score)
    {
        return score >= 80 && score <= 100;
    }

    private bool IsGradeBPlus(int score)
    {
        return score >= 75 && score <= 79;
    }

    private bool IsGradeB(int score)
    {
        return score >= 70 && score <= 74;
    }

    private bool IsGradeCPlus(int score)
    {
        return score >= 65 && score <= 69;
    }
    private bool IsGradeC(int score)
    {
        return score >= 60 && score <= 64;
    }
    private bool IsGradeDPlus(int score)
    {
        return score >= 55 && score <= 59;
    }
    private bool IsGradeD(int score)
    {
        return score >= 50 && score <= 54;
    }

    private bool IsGradeF(int score)
    {
        return score >= 0 && score <= 49;
    }

    public string ShowGrade()
    {
        return _grade;
    }

    public int ShowScore()
    {
        return _score;
    }
}