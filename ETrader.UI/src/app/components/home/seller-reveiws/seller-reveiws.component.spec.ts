import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SellerReveiwsComponent } from './seller-reveiws.component';

describe('SellerReveiwsComponent', () => {
  let component: SellerReveiwsComponent;
  let fixture: ComponentFixture<SellerReveiwsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SellerReveiwsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SellerReveiwsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
