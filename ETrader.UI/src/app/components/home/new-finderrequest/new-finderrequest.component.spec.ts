import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewFinderrequestComponent } from './new-finderrequest.component';

describe('NewFinderrequestComponent', () => {
  let component: NewFinderrequestComponent;
  let fixture: ComponentFixture<NewFinderrequestComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewFinderrequestComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewFinderrequestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
