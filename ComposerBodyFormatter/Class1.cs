using Fiddler;

namespace ComposerBodyFormatter
{
    //public class Violin: IAutoTamper
    //{
    //    private readonly string _sUserAgent;

    //    public Violin()
    //    {
    //        _sUserAgent = "Violin";
    //    }

    //    public void OnLoad()
    //    {
    //    }

    //    public void OnBeforeUnload()
    //    {
    //    }

    //    public void AutoTamperRequestBefore(Session oSession)
    //    {
    //        oSession.oRequest["User-Agent"] = _sUserAgent;
    //    }

    //    public void AutoTamperRequestAfter(Session oSession)
    //    {
    //    }

    //    public void AutoTamperResponseBefore(Session oSession)
    //    {
    //    }

    //    public void AutoTamperResponseAfter(Session oSession)
    //    {
    //    }

    //    public void OnBeforeReturningError(Session oSession)
    //    {
    //    }
    //}
    //public class ExecExtend : IHandleExecAction
    //{
    //    public void OnLoad() { }

    //    public void OnBeforeUnload() { }

    //    public bool OnExecAction(string sCommand)
    //    {
    //        var parameters = Utilities.Parameterize(sCommand);
    //        switch (parameters[0])
    //        {
    //            case "dar":
    //                if (parameters.Length != 2)
    //                {
    //                    FiddlerApplication.UI.SetStatusText("Please specify who to say hi!");
    //                    return true;
    //                }
    //                FiddlerApplication.UI.SetStatusText($"All say hi to {parameters[1]}");

    //                FiddlerApplication.UI.ShowAlert(new frmAlert("Hello!","Hello Avensians!","Asd"));
    //                break;
    //        }
    //        return true;
    //    }
    //}
}
