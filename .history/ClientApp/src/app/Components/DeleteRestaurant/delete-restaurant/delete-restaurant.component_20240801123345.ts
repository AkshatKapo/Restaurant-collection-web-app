import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { RestaurantService } from 'src/app/Services/Services/restaurant.service';

@Component({
  selector: 'app-delete-restaurant',
  templateUrl: './delete-restaurant.component.html',
  styleUrls: ['./delete-restaurant.component.css']
})
export class DeleteRestaurantComponent implements OnInit {
  food_restaurant:any;
  constructor(private route: ActivatedRoute, private router:Router,private restaurant_service: RestaurantService){

  }
  ngOnInit(): void {

    this.restaurant_service.getRestaurantById(this.route.snapshot.params.id).subscribe(data=>{
      this.food_restaurant=data;
    })
    
  }
  deleterestaurant(id:number){
     this.re
  }
  

}