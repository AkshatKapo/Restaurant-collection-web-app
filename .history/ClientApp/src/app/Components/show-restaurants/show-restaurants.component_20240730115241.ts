import { Component, OnInit } from '@angular/core';
import { Restaurant } from 'src/app/Interfaces/restaurant';

@Component({
  selector: 'app-show-restaurants',
  templateUrl: './show-restaurants.component.html',
  styleUrls: ['./show-restaurants.component.css']
})
export class ShowRestaurantsComponent implements OnInit {

  restaurants:Restaurant
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

  

}
