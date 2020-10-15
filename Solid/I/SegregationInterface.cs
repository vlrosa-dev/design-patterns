namespace Solid.I
{
    public class SegregationInterface
    {
        
    }

    interface IAves
    {
        public void SetLocalizacao(float longitude, float latitude);

        public void Renderizar();
    }

    interface IAvesQueVoam : IAves
    {
        public void SetAltitude(float altitude);
    }

    class Papagaio : IAvesQueVoam
    {
        public void SetLocalizacao(float longitude, float latitude)
        {
            throw new System.NotImplementedException();
        }

        public void Renderizar()
        {
            throw new System.NotImplementedException();
        }

        public void SetAltitude(float altitude)
        {
            throw new System.NotImplementedException();
        }
    }

    class Pinguim : IAves
    {
        public void SetLocalizacao(float longitude, float latitude)
        {
            throw new System.NotImplementedException();
        }

        public void Renderizar()
        {
            throw new System.NotImplementedException();
        }
    }
}