using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseProject.Models
{
    public class ProfileViewModel
    {
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public int RoomNo { get; set; }
        public int FloorNo { get; set; }
        public decimal Rent { get; set; }
        public string City { get; set; }  // Foreign key to Address
        public string DetailsLocation { get; set; }
        public int PropertyOwnerId { get; set; }

        
        public string PropertyType { get; set; }
        public string Essentials { get; set; }
        public byte[] Image1 { get; set; }
        public byte[] Image2 { get; set; }
        public byte[] Image3 { get; set; }
        public byte[] Video { get; set; }
    }
}

/*
  <!-- Property Section -->
         <div id="property-section" style="display: none;">
             <div class="main-content">
                 <h2>Property</h2>
                 <form enctype="multipart/form-data" method="post" action="@Url.Action("SaveProperty", "Home")">
                     <!-- Property Name -->
                     <label for="propertyName">Property Name</label>
                     <input type="text" id="propertyName" name="PropertyName" placeholder="Enter property name" value="@Model.PropertyName" required>

                     <!-- Room Number -->
                     <label for="roomNo">Number of Rooms</label>
                     <input type="number" id="roomNo" name="RoomNo" placeholder="Enter number of rooms" value="@Model.RoomNo" required>

                     <!-- Floor Number -->
                     <label for="floorNo">Floor Number</label>
                     <input type="number" id="floorNo" name="FloorNo" placeholder="Enter floor number" value="@Model.FloorNo" required>

                     <!-- Rent -->
                     <label for="rent">Rent (in currency)</label>
                     <input type="number" id="rent" name="Rent" placeholder="Enter rent amount" value="@Model.Rent" required>

                     <!-- Address -->
                     <label for="city">City</label>
                     <input type="text" id="city" name="City" placeholder="Enter City" value="@Model.City" required>

                     <label for="detailslocation">Details Location</label>
                     <input type="text" id="detailslocation" name="DetailsLocation" placeholder="Enter Details Location" value="@Model.DetailsLocation" required>

                     <!-- Property Owner ID -->
                     <label for="propertyOwnerId">Property Owner ID</label>
                     <input type="number" id="propertyOwnerId" name="PropertyOwnerId" value="@Model.PropertyOwnerId" readonly>

                     <!-- Images -->
                     <label for="image1">Upload Picture 1</label>
                     <input type="file" id="image1" name="Image1" accept="image/*">

                     <label for="image2">Upload Picture 2</label>
                     <input type="file" id="image2" name="Image2" accept="image/*">

                     <label for="image3">Upload Picture 3</label>
                     <input type="file" id="image3" name="Image3" accept="image/*">

                     <!-- Video -->
                     <label for="video">Upload Video</label>
                     <input type="file" id="video" name="Video" accept="video/*">

                     <!-- Property Type -->
                     <!-- Property Type -->
                     <label for="propertyType">Property Type</label>
                     <select id="propertyType" name="propertyType" required>
                         <option value="bachelor">Bachelor</option>
                         <option value="family">Family</option>
                         <option value="shared">Shared</option>
                     </select>

                     <!-- Essentials -->
                     <!-- Essentials -->
                     <label for="essentialsList">Essentials</label>
                     <ul id="essentialsList"></ul>
                     <button type="button" onclick="addEssential()">Add Essential</button>

                     <!-- Submit Button -->
                     <button type="submit">Save Changes</button>
                 </form>
             </div>
         </div>
     </div>  */