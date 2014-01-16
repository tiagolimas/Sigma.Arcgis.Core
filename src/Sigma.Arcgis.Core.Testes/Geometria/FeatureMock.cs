using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;

namespace Sigma.Arcgis.Core.Testes.Geometria
{
    public class FeatureMock:IFeature
    {
        public IObjectClass Class
        {
            get { throw new NotImplementedException(); }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public ESRI.ArcGIS.Geometry.IEnvelope Extent
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

        public bool HasOID
        {
            get { throw new NotImplementedException(); }
        }

        public int OID
        {
            get { 
                    Random random = new Random();
                    int numero = random.Next(0, 10000);

                    return numero;
                }
        }

        public ESRI.ArcGIS.Geometry.IGeometry Shape
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public ESRI.ArcGIS.Geometry.IGeometry ShapeCopy
        {
            get 
            {
                IPointCollection col = new PolygonClass();
                IPoint p1 = new PointClass();
                IPoint p2 = new PointClass();
                IPoint p3 = new PointClass();
                IPoint p4 = new PointClass();
                IPoint p5 = new PointClass();

                p1.PutCoords(0, 0);
                p2.PutCoords(0, 1);
                p3.PutCoords(1, 1);
                p4.PutCoords(1, 0);
                p5.PutCoords(0, 0);

                col.AddPoint(p1);
                col.AddPoint(p2);
                col.AddPoint(p3);
                col.AddPoint(p4);
                col.AddPoint(p5);

                return col as IGeometry;
            }
        }

        public void Store()
        {
            throw new NotImplementedException();
        }

        public ITable Table
        {
            get { throw new NotImplementedException(); }
        }

        public object get_Value(int Index)
        {
            throw new NotImplementedException();
        }

        public void set_Value(int Index, object Value)
        {
            throw new NotImplementedException();
        }
    }
}
