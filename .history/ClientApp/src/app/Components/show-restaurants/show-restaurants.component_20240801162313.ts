import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Restaurant } from 'src/app/Interfaces/restaurant';
import { RestaurantService } from 'src/app/Services/Services/restaurant.service';

@Component({
  selector: 'app-show-restaurants',
  templateUrl: './show-restaurants.component.html',
  styleUrls: ['./show-restaurants.component.css']
})
export class ShowRestaurantsComponent implements OnInit {

  restaurants:Restaurant[]=[];
  constructor(private restaurantservice: RestaurantService, private router: Router){

  }
  ngOnInit(): void {
    this.showRestaurants();
  }
  showRestaurants(){
      this.restaurantservice.getAllRestaurants().subscribe(
        (rest_data:Restaurant[]) =>{

          this.restaurants = rest_data;
          console.log(this.restaurants);

        }
        

      );

  }
  deleterest(id:number){
    this.router.navigate(['/delete-restaurant/'+]);
  }

}
