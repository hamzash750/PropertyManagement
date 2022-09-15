import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PropertSubmission1Component } from './propert-submission1.component';

describe('PropertSubmission1Component', () => {
  let component: PropertSubmission1Component;
  let fixture: ComponentFixture<PropertSubmission1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PropertSubmission1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PropertSubmission1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
