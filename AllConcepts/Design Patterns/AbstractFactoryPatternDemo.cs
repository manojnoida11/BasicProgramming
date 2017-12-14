using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
   

    public class AbstractFactoryPatternDemo
    {
        public void TestAbstractFactory()
        {
            AbstractFactory _factory = FactoryProducer.GetFactory("SHAPE");
            IShape shp = _factory.GetShape("RECTANGLE");
            shp.Draw();

            _factory = FactoryProducer.GetFactory("COLOR");
             IColor clr = _factory.GetColor("RED");
             clr.Fill();
        }

        
    }

    public interface IShape
    {
        void Draw();
    }

    public interface IColor
    {
        void Fill();
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle Draw method");
        }
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle draw method");
        }
    }

    public class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Red Fill");
        }
    }

    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Green Fill");
        }
    }

    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shape);
        public abstract IColor GetColor(string color);
    }

    public class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shape)
        {
            if (shape == "RECTANGLE")
                return new Rectangle();

            if(shape == "CIRCLE")
                return new Circle();

            return null;
        }

        public override IColor GetColor(string color)
        {
            throw new NotImplementedException();
        }
    }

    public class ColorFactory : AbstractFactory
    {
        public override IShape GetShape(string shape)
        {
            throw new NotImplementedException();
        }

        public override IColor GetColor(string color)
        {
            if (color == "RED")
                return new Red();

            if (color == "GREEN")
                return new Green();

            return null;
        }
    }

    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string strChoice)
        {
            if (strChoice == "SHAPE")
                return new ShapeFactory();

            if (strChoice == "COLOR")
                return new ColorFactory();

            return null;
        }
    }

  
   



   
}
