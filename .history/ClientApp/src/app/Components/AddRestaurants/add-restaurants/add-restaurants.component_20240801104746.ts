import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Restaurant } from 'src/app/Interfaces/restaurant';
import { RestaurantService } from 'src/app/Services/Services/restaurant.service';

@Component({
  selector: 'app-add-restaurants',
  templateUrl: './add-restaurants.component.html',
  styleUrls: ['./add-restaurants.component.css']
})
export class AddRestaurantsComponent implements OnInit {

  addRestaurantForm:FormGroup;// property of Formgroup use to hold and manage the form controls 

  constructor(private fb:FormBuilder, private restaurant_service:RestaurantService){

     this.addRestaurantForm=this.fb.group({
      restaurant_Name: ['', Validators.required],
      location: ['', Validators.required],
      food: ['', Validators.required],
      rate: [0, [Validators.required, Validators.min(0), Validators.max(5)]]
    });

     }

     ngOnInit(): void {
      this.AddResta();
    }
    

  }
 



  

}
