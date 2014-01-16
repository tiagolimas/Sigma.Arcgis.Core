using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Geodatabase;

namespace Sigma.Arcgis.Core.Testes.Geometria
{
    public class CursorMock : IFeatureCursor
    {
        private List<IFeature> _mockFeatures = new List<IFeature>();
        private int _featureIndex = -1;

        public CursorMock()
        {
            _mockFeatures.Add(new FeatureMock());
            _mockFeatures.Add(new FeatureMock());
            _mockFeatures.Add(new FeatureMock());
            _mockFeatures.Add(new FeatureMock());
        }

        public void DeleteFeature()
        {
            throw new NotImplementedException();
        }

        public IFields Fields
        {
            get { throw new NotImplementedException(); }
        }

        public int FindField(string Name)
        {
            throw new NotImplementedException();
        }

        public void Flush()
        {
            throw new NotImplementedException();
        }

        public object InsertFeature(IFeatureBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public IFeature NextFeature()
        {
            _featureIndex++;
            IFeature mockFeature = null;
            try
            {
                mockFeature = _mockFeatures[_featureIndex];
            }
            catch (IndexOutOfRangeException indexError)
            {
                return null;
            }

            return mockFeature;
        }

        public void UpdateFeature(IFeature Object)
        {
            throw new NotImplementedException();
        }
    }
}
