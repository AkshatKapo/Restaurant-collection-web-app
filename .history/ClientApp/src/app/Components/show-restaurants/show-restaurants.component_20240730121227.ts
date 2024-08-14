import { Component, OnInit } from '@angular/core';
import { Restaurant } from 'src/app/Interfaces/restaurant';
import { RestaurantService } from 'src/app/Services/Services/restaurant.service';

@Component({
  selector: 'app-show-restaurants',
  templateUrl: './show-restaurants.component.html',
  styleUrls: ['./show-restaurants.component.css']
})
export class ShowRestaurantsComponent implements OnInit {

  restaurants:Restaurant[]=[];
  constructor(private restaurantservice: RestaurantService){

  }
  ngOnInit(): void {
    this.showRestaurants();
  }
  showRestaurants(){
      this.restaurantservice.getAllRestaurants().subscribe(
        
      )
  }

  

  

}
