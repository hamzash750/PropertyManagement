import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BuyerPropertyComponent } from './buyer-property.component';

describe('BuyerPropertyComponent', () => {
  let component: BuyerPropertyComponent;
  let fixture: ComponentFixture<BuyerPropertyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BuyerPropertyComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BuyerPropertyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
