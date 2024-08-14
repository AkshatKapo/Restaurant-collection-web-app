import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Restaurant } from 'src/app/Interfaces/restaurant';

@Component({
  selector: 'app-add-restaurants',
  templateUrl: './add-restaurants.component.html',
  styleUrls: ['./add-restaurants.component.css']
})
export class AddRestaurantsComponent implements OnInit {

  addRestaurantForm:FormGroup;// property of Formgroup use to hold and manage the form controls 

  constructor(private fb:FormBuilder, private restaurant_service){

  }
  ngOnInit(): void {
    this.AddResta();
  }
  



  

}
