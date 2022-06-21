using MSharp;

namespace App
{
    public class Project : MSharp.Project
    {
        public Project()
        {
            Name("MY.MICROSERVICE.NAME")
                .SolutionFile("MY.MICROSERVICE.NAME.sln")
                .IsMicroservice()
                .ViewButtonsLocation("Top")
                .NetCore();

            Layout("Default").Default().AjaxRedirect().VirtualPath("~/Views/Layouts/Default.cshtml");
            Layout("Modal").Modal().VirtualPath("~/Views/Layouts/Modal.cshtml");

            // Note: Often in micro-services you can have a large number of roles.
            // In the following example we're creating a large list of role/level permissions
            // that can be used in the UI M# definitions.
            foreach (var role in "Dev,QA,BA,PM,AM,Director,Designer,IT,Reception,PA,Sales".Split(','))
                foreach (var level in ",Junior,Senior,Lead,Head".Split(','))
                    Role(level + role);

            AutoTask("Sample task")
                   .Every(1, TimeUnit.Hour)
                   .Run("//int i=0;");
        }
    }
}
