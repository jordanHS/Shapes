using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {

    [TestMethod]
    public void Sphere_GetVoume_VolumeOfSphere()
    {
      // Arrange
      Sphere newSphere = new Sphere(4);
      // Act
      double result = newSphere.GetVolume();
      // Assert
      Assert.AreEqual(result, 268.08);
    }

//     // [TestMethod]
//     // public void Cube_GetSurfaceArea_SurfaceAreaOfCube()
//     // {
//     //     Rectangle newRectangle = new Rectangle(4, 4);
//     //     Cube newCube = new Cube(newRectangle);
//     //     int result = newCube.GetSurfaceArea();
//     //     Assert.AreEqual(result, 96);
//     // }

  }  
  } 