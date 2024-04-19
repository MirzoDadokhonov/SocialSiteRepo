namespace WebAPI
{
    public static class ApiEndpoints
    {
        private const string ApiBase = "api";

        public static class SocialSite
        {
            private string _nameOfClass;

            public SocialSite(string nameOfClass)
            {

            }

            private const string Base = $"{ApiBase}/{df}}";
            public const string Create = Base;
            public const string Get = $"{Base}/{{id:guid}}";
            public const string GetAll = Base;
            public const string Update = $"{Base}/{{id:guid}}";
            public const string Delete = $"{Base}/{{id:guid}}";
        }
    }
}
