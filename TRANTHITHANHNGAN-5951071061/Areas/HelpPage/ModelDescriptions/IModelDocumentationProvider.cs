using System;
using System.Reflection;

namespace TRANTHITHANHNGAN_5951071061.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}