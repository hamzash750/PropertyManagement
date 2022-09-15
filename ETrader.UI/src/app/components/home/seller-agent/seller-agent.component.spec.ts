import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SellerAgentComponent } from './seller-agent.component';

describe('SellerAgentComponent', () => {
  let component: SellerAgentComponent;
  let fixture: ComponentFixture<SellerAgentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SellerAgentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SellerAgentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
