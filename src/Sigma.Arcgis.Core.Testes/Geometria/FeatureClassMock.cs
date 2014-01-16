using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Geodatabase;


namespace Sigma.Arcgis.Core.Testes.Geometria
{
    public class FeatureClassMock : IFeatureClass
    {
        public void AddField(IField Field)
        {
            throw new NotImplementedException();
        }

        public void AddIndex(IIndex Index)
        {
            throw new NotImplementedException();
        }

        public string AliasName
        {
            get { throw new NotImplementedException(); }
        }

        public IField AreaField
        {
            get { throw new NotImplementedException(); }
        }

        public ESRI.ArcGIS.esriSystem.UID CLSID
        {
            get { throw new NotImplementedException(); }
        }

        public IFeature CreateFeature()
        {
            throw new NotImplementedException();
        }

        public IFeatureBuffer CreateFeatureBuffer()
        {
            throw new NotImplementedException();
        }

        public void DeleteField(IField Field)
        {
            throw new NotImplementedException();
        }

        public void DeleteIndex(IIndex Index)
        {
            throw new NotImplementedException();
        }

        public ESRI.ArcGIS.esriSystem.UID EXTCLSID
        {
            get { throw new NotImplementedException(); }
        }

        public object Extension
        {
            get { throw new NotImplementedException(); }
        }

        public ESRI.ArcGIS.esriSystem.IPropertySet ExtensionProperties
        {
            get { throw new NotImplementedException(); }
        }

        public int FeatureClassID
        {
            get { throw new NotImplementedException(); }
        }

        public int FeatureCount(IQueryFilter QueryFilter)
        {
            throw new NotImplementedException();
        }

        public IFeatureDataset FeatureDataset
        {
            get { throw new NotImplementedException(); }
        }

        public esriFeatureType FeatureType
        {
            get { throw new NotImplementedException(); }
        }

        public IFields Fields
        {
            get { throw new NotImplementedException(); }
        }

        public int FindField(string Name)
        {
            throw new NotImplementedException();
        }

        public IFeature GetFeature(int ID)
        {
            throw new NotImplementedException();
        }

        public IFeatureCursor GetFeatures(object fids, bool Recycling)
        {
            throw new NotImplementedException();
        }

        public bool HasOID
        {
            get { throw new NotImplementedException(); }
        }

        public IIndexes Indexes
        {
            get { throw new NotImplementedException(); }
        }

        public IFeatureCursor Insert(bool useBuffering)
        {
            throw new NotImplementedException();
        }

        public IField LengthField
        {
            get { throw new NotImplementedException(); }
        }

        public string OIDFieldName
        {
            get { throw new NotImplementedException(); }
        }

        public int ObjectClassID
        {
            get { throw new NotImplementedException(); }
        }

        //Implementação do CursorMock
        public IFeatureCursor Search(IQueryFilter filter, bool Recycling)
        {
            IFeatureCursor cursor = new CursorMock();
            return cursor;
        }

        public ISelectionSet Select(IQueryFilter QueryFilter, esriSelectionType selType, esriSelectionOption selOption, IWorkspace selectionContainer)
        {
            throw new NotImplementedException();
        }

        public string ShapeFieldName
        {
            get { throw new NotImplementedException(); }
        }

        public ESRI.ArcGIS.Geometry.esriGeometryType ShapeType
        {
            get { throw new NotImplementedException(); }
        }

        public IFeatureCursor Update(IQueryFilter filter, bool Recycling)
        {
            throw new NotImplementedException();
        }

        public IEnumRelationshipClass get_RelationshipClasses(esriRelRole Role)
        {
            throw new NotImplementedException();
        }
    }
}
