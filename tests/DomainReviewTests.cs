using VistaSimAgentScope;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(62, 51, 16, 90);
        if (DomainReviewLens.Score(item) != 217) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
