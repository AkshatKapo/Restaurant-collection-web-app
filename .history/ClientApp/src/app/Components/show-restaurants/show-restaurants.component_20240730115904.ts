import { Component, OnInit } from '@angular/core';
import { Restaurant } from 'src/app/Interfaces/restaurant';
import { RestaurantService } from '../services/restaurant.service';  // Adjust the path as needed
@Component({
  selector: 'app-show-restaurants',
  templateUrl: './show-restaurants.component.html',
  styleUrls: ['./show-restaurants.component.css']
})
export class ShowRestaurantsComponent implements OnInit {

  restaurants:Restaurant[]=[]
  ngOnInit(): void {
    this.showRestaurants();
  }
  showRestaurants(){
    this.restaurant.
  }

  

  

}
