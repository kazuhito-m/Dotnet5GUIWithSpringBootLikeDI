namespace Dotnet5GUIWithSpringBootLikeDI.Domain.Model.Miura
{
    public class TheMiura
    {
        public string GivenName { get; private set; }
        public string FamilyName { get; private set; }

        public TheMiura(string givenName, string familyName)
        {
            GivenName = givenName;
            FamilyName = familyName;
        }

        public override string ToString() => $"{GivenName} {FamilyName}";
    }
}
