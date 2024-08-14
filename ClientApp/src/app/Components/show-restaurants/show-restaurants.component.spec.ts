import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowRestaurantsComponent } from './show-restaurants.component';

describe('ShowRestaurantsComponent', () => {
  let component: ShowRestaurantsComponent;
  let fixture: ComponentFixture<ShowRestaurantsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowRestaurantsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ShowRestaurantsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
